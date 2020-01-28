using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPDDDChap18.DomainServices.OnlineGaming.WithDomainServices.Model
{
    public class Score
    {
        public int Value { get; private set; }

        public Score(int value)
        {
            this.Value = value;
        }

        public Score Add(Score amount)
        {
            return new Score(this.Value + amount.Value);
        }

        public Score Subtract(Score amount)
        {
            return new Score(this.Value - amount.Value);
        }

        public static bool operator >(Score left, Score right)
        {
            return left.Value > right.Value;
        }

        public static Boolean operator <(Score left, Score right)
        {
            return left.Value < right.Value;
        }
    }
}
