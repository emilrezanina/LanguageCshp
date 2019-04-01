using System;
using System.Collections.Generic;
using System.Linq;

namespace ChampionsLeague.Common
{
    public class Footballers
    {
        public const uint FOOTBALLERS_CAPACITY = 30;

        private readonly Footballer[] footballers = new Footballer[FOOTBALLERS_CAPACITY];

        public uint Count { get; private set; }

        public Footballers()
        {

        }

        public Footballers(params Footballer[] footballers)
        {
            if (footballers.Length == 0)
                throw new ArgumentOutOfRangeException("Invalid size of input footballers.");
            foreach (var footballer in footballers)
            {
                Add(footballer);
            }
        }

        public void Remove(uint index, bool reorganize = true)
        {
            if (Count == 0)
                throw new ArgumentOutOfRangeException();
            if (index > Count)
                throw new IndexOutOfRangeException();
            footballers[index] = null;
            if (reorganize)
                ReorganizeAfterRemove(index);
            Count--;
        }

        public void Add(Footballer footballer)
        {
            if (Count == FOOTBALLERS_CAPACITY)
                throw new ArgumentOutOfRangeException();
            footballers[Count] = footballer;
            Count++;
        }

        public Footballer this[uint index]
        {
            get
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();
                return footballers[index];
            }
            set
            {
                if (index >= Count)
                    throw new IndexOutOfRangeException();
                footballers[index] = value;
            }
        }


        public IEnumerable<(FootballClub, uint)> FindBestFootbalersClubs()
        {
            IDictionary<FootballClub, uint> clubGoals = new Dictionary<FootballClub, uint>();
            for (int i = 0; i < Count; i++)
            {
                if (footballers[i].Club == FootballClub.None)
                    continue;
                if (clubGoals.ContainsKey(footballers[i].Club))
                    clubGoals[footballers[i].Club] += footballers[i].GoalCount;
                else
                    clubGoals.Add(footballers[i].Club, footballers[i].GoalCount);
            }
            return clubGoals.Where(item => item.Value == clubGoals.Max(pair => pair.Value)).Select(pair => (pair.Key, pair.Value));
        }

        private void ReorganizeAfterRemove(uint index)
        {
            if (index == Count)
                return;
            for (uint i = index; i < Count - 1; i++)
            {
                footballers[i] = footballers[i + 1];
            }
        }

        public void Reorganize()
        {
            for (int i = 0; i < FOOTBALLERS_CAPACITY - 1; i++)
            {
                if (footballers[i] == null)
                {
                    footballers[i] = footballers[i + 1];
                    footballers[i + 1] = null;
                }
            }
        }
    }
}
