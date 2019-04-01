using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChampionsLeague.Common.Tests
{
    [TestFixture]
    public class FootballersTests
    {
        [Test]
        public void InitFootballersAreEmpty()
        {
            Footballers footballers = new Footballers();
            Assert.IsTrue(footballers.Count == 0);
        }

        [Test]
        public void IntByParamsIncializeCorrectData()
        {
            Footballers footballers = new Footballers(
                new Footballer("Footballer0", FootballClub.None, 0), 
                new Footballer("Footballer1", FootballClub.None, 0));
            Assert.AreEqual(2, footballers.Count);
        }

        [Test]
        public void InitByArrayInicializeCorrectData()
        {
            Footballer[] footballersSource = new Footballer[5]
            {
                new Footballer("Footballer0", FootballClub.None, 0),
                new Footballer("Footballer1", FootballClub.None, 0),
                new Footballer("Footballer2", FootballClub.None, 0),
                new Footballer("Footballer3", FootballClub.None, 0),
                new Footballer("Footballer4", FootballClub.None, 0),
            };
            Footballers footballers = new Footballers(footballersSource);
            Assert.AreEqual(footballersSource.Length, footballers.Count);
            for (uint i = 0; i < footballers.Count; i++)
            {
                Assert.AreEqual(footballersSource[i], footballers[i]);
            }
        }

        private Footballers GetFilledFootballersToCapacity()
        {
            Footballers footballers = new Footballers();
            for (uint i = 0; i < Footballers.FOOTBALLERS_CAPACITY; i++)
            {
                footballers.Add(new Footballer($"footballer{i.ToString()}", FootballClub.None, 0));
                Assert.IsTrue(footballers.Count == i + 1);
            }
            return footballers;
        }

        [Test]
        public void AfterInsertFootballersHadCorrectOrder()
        {
            Footballers footballers = GetFilledFootballersToCapacity();
            for (uint i = 0; i < footballers.Count; i++)
            {
                Assert.AreEqual(new Footballer($"footballer{i.ToString()}", FootballClub.None, 0), footballers[i]);
            }
        }

        [Test]
        public void InsertUnderFootballerCapacityThrowException()
        {
            Footballers footballers = GetFilledFootballersToCapacity();
            Assert.Throws<ArgumentOutOfRangeException>(() => footballers.Add(new Footballer("Under capacity", FootballClub.None, 0)));
        }

        [TestCase((uint)0)]
        [TestCase((uint)1)]
        [TestCase((uint)2)]
        [TestCase((uint)29)]
        public void AfterRemoveFootballersHadCorrectOrder(uint index)
        {
            Footballers footballers = GetFilledFootballersToCapacity();
            uint previousCount = footballers.Count;
            Footballer removedFootballer = footballers[index];
            string expectedNextFootballerName = $"footballer{(index + 1).ToString()}";
            footballers.Remove(index);
            Assert.AreEqual(previousCount - 1, footballers.Count);
            if (index == footballers.Count)
                return;
            Assert.AreNotEqual(removedFootballer, footballers[index]);
            Assert.AreEqual(footballers[index].Name, expectedNextFootballerName);
        }

        [Test]
        public void RemoveFootballerFromEmptyFootballersThrowException()
        {
            Footballers footballers = new Footballers();
            Assert.Throws<ArgumentOutOfRangeException>(() => footballers.Remove(0));
        }

        [Test]
        public void TryRemoveFootballerOnIlegallPositionThrowException()
        {
            Footballers footballers = GetFilledFootballersToCapacity();
            Assert.Throws<IndexOutOfRangeException>(() => footballers.Remove(Footballers.FOOTBALLERS_CAPACITY));
        }

        [Test]
        public void TryAccessToFootballerOnIllegallPositionThrowException()
        {
            Footballers footballers = new Footballers();
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                Footballer temp = footballers[0];
            });
        }

        [Test]
        public void TrySetFootballerOnIllegallPositionThrowException()
        {
            Footballers footballers = new Footballers();
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                footballers[0] = null;
            });
        }

        private static readonly IList<Tuple<Footballers, IList<(FootballClub, uint)>>> footballersCases
            = new List<Tuple<Footballers, IList<(FootballClub, uint)>>>()
            {
                new Tuple<Footballers, IList<(FootballClub, uint)>>(
                    new Footballers(
                        new Footballer() { Name = "First", Club = FootballClub.Arsenal, GoalCount = 5 },
                        new Footballer() { Name = "Second", Club = FootballClub.Barcelone, GoalCount = 4 },
                        new Footballer() { Name = "Third", Club = FootballClub.None, GoalCount = 8 },
                        new Footballer() { Name = "Fourth", Club = FootballClub.Arsenal, GoalCount = 2 },
                        new Footballer() { Name = "Fifth", Club = FootballClub.FCPorto, GoalCount = 5 },
                        new Footballer() { Name = "Sixth", Club = FootballClub.RealMadrid, GoalCount = 7 }),
                    new List<(FootballClub, uint)>(){
                        (FootballClub.Arsenal, 7),
                        (FootballClub.RealMadrid, 7) }
                ),
                new Tuple<Footballers, IList<(FootballClub, uint)>>(
                     new Footballers(
                        new Footballer() { Name = "First", Club = FootballClub.Arsenal, GoalCount = 1 },
                        new Footballer() { Name = "Second", Club = FootballClub.Barcelone, GoalCount = 4 },
                        new Footballer() { Name = "Third", Club = FootballClub.None, GoalCount = 8 },
                        new Footballer() { Name = "Fourth", Club = FootballClub.Arsenal, GoalCount = 2 },
                        new Footballer() { Name = "Fifth", Club = FootballClub.FCPorto, GoalCount = 5 },
                        new Footballer() { Name = "Sixth", Club = FootballClub.RealMadrid, GoalCount = 2 }),
                     new List<(FootballClub, uint)>()
                     {
                         (FootballClub.FCPorto, 5)
                     }
                ),
                new Tuple<Footballers, IList<(FootballClub, uint)>>(
                     new Footballers(
                        new Footballer() { Name = "First", Club = FootballClub.None, GoalCount = 1 },
                        new Footballer() { Name = "Second", Club = FootballClub.None, GoalCount = 4 }),
                     new List<(FootballClub, uint)>() { }
                )
            };

        [Test, TestCaseSource(nameof(footballersCases))]
        public void FindBestFootbalersClubsTest(Tuple<Footballers, IList<(FootballClub, uint)>> actualExpectedPair)
        {
            IEnumerable<(FootballClub, uint)> bestClubs = actualExpectedPair.Item1.FindBestFootbalersClubs();
            Assert.AreEqual(actualExpectedPair.Item2.Count(), bestClubs.Count());
            if (bestClubs.Count() == 0)
                return;
            foreach (var club in bestClubs)
            {
                Assert.IsTrue(actualExpectedPair.Item2.Any(item => item.Item1 == club.Item1));
            }
        }
    }
}