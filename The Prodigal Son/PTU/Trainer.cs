using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace The_Prodigal_Son
{
    public class Trainer
    {
        public string Name { get; set; }
        public Stat[] stats;
        public Team team;
        public void UpdateName(string name)
        {
            Name = name;
        }

        public void Refresh()
        {

        }

        public int RollStat(string stat)
        {
            return 0;
        }
    }
}