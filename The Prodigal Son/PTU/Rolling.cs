using System;
using System.Collections.Generic;
using System.Text;

namespace The_Prodigal_Son
{
    public class Rolling
    {
        public string RollStat(string statName)
        {
            return "Not yet Implimented.";
        }
        public Tuple<int, string> RollDice(int count, int dice)
        {
            if(dice == 0 || count == 0) { Console.WriteLine("Cannot roll 0 die!"); throw new ArgumentOutOfRangeException(); }
            int total = 0;
            List<int> rolled = new List<int>();

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int die = random.Next(1, dice);
                rolled.Insert(i, die);
                total += die;
            }

            return new Tuple<int, string>(total, "You rolled a: " + total.ToString() + " " + string.Join(", ", rolled.ToArray()));
        }
    }
}