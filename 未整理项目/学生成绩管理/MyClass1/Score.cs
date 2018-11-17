using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass1
{
    class Score
    {
        private List<int> gardes;
        private int total;

        public int this[int index]
        {
            get { return gardes[index]; }
            set { gardes[index] = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public Score(params int[] gardes)
        {
            this.gardes = new List<int>(gardes);
            total = InTotal();
        }

        public Score(Score other)
        {
            this.gardes = new List<int>(other.gardes);
            total = InTotal();
        }

        public Score(string gardes)
        {
            string[] str = gardes.Trim().Split(',');
            this.gardes = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                this.gardes.Add(Convert.ToInt32(str[i]));
            }

            total = InTotal();
        }

        public int Max()
        {
            int max = gardes[0];

            foreach (int sco in gardes)
            {
                if (max < sco)
                {
                    max = sco;
                }
            }

            return max;
        }

        public int InTotal()
        {
            int sum = 0;

            foreach (int sco in gardes)
            {
                sum += sco;
            }

            return sum;
        }

        public override string ToString()
        {
            return Total.ToString();
        }

        public  string  ConvertToString()
        {
            string str = " ";

            for (int i = 0; i < gardes.Count; i++)
            {
                str += gardes[i] + " ";
            }

            return str;
        }
    }
}
