using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBot
{
    public class Dice
    {
        private static Random random = new Random(DateTime.Now.Millisecond);

        public Dice()
        {
            this.Roll();
        }

        public int Number { get; set; }

        public void Roll()
        {
            this.Number = random.Next(1, 7);
        }
    }
}
