using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeague.Common
{
    public class Footballer
    {
        public string Name { get; set; }
        public FootballClub Club { get; set; }
        public uint GoalCount { get; set; }

        public Footballer()
        {

        }

        public Footballer(Footballer source)
        {
            Name = source.Name;
            Club = source.Club;
            GoalCount = source.GoalCount;
        }

        public Footballer(string name, FootballClub club, uint goalCount)
        {
            Name = name;
            Club = club;
            GoalCount = goalCount;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Footballer second = obj as Footballer;
            if (Name != second.Name) return false;
            if (Club != second.Club) return false;
            return GoalCount == second.GoalCount;
        }

        public override int GetHashCode()
        {
            var hashCode = 773268576;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Club.GetHashCode();
            hashCode = hashCode * -1521134295 + GoalCount.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Footballer first, Footballer second)
        {
            if (ReferenceEquals(first, second))
                return true;

            if (ReferenceEquals(first, null))
                return false;
            if (ReferenceEquals(second, null))
                return false;

            return (first.Name == second.Name
                    && first.Club == second.Club
                    && first.GoalCount == second.GoalCount);
        }

        public static bool operator !=(Footballer first, Footballer second)
        {
            return !(first == second);
        }

        public Footballer Clone()
        {
            return new Footballer(this);
        }

        public override string ToString()
        {
            return new StringBuilder(Name).Append("; ").Append(Club.ToString()).Append("; ").Append(GoalCount.ToString()).ToString();
        }
    }
}
