using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBot
{
    public class BarDice
    {
        private List<Dice> rollingDice;

        private List<Dice> heldDice;

        public BarDice()
        {
            this.rollingDice = new List<Dice>();
            this.heldDice = new List<Dice>();

            for (int i = 0; i < 5; i ++)
            {
                Dice die = new Dice();

                this.rollingDice.Add(die);
            }
        }

        public void Roll()
        {
            foreach (Dice d in rollingDice)
            {
                d.Roll();
            }

            this.ShowDice(this.rollingDice);
        }

        public void Hold(int dieToHold)
        {
            int diceNumber = dieToHold - 1;

            this.heldDice.Add(this.rollingDice[diceNumber]);

            this.rollingDice.RemoveAt(diceNumber);
        }

        public string ShowDice(List<Dice> diceList)
        {
            string rolledDice = string.Empty;
            bool isFirst = true;
            int counter = 1;

            foreach (Dice d in diceList)
            {
                if (isFirst == true)
                {
                    rolledDice += "Dice" + counter + ": [" + d.Number + "]";

                    isFirst = false;
                }
                else
                {
                    rolledDice += ", Dice" + counter + ": [" + d.Number + "]";
                }

                counter++;
            }

            return rolledDice;
        }

        public string ShowRolledDice()
        {
            return this.ShowDice(this.rollingDice);
        }

        public string ShowHeldDice()
        {
            return this.ShowDice(this.heldDice);
        }

        public string ShowAllDice()
        {
            return this.ShowHeldDice() + ", " + this.ShowRolledDice();
        }
    }
}
