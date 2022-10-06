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
        public string Link { get; set; }
        public string PlayerID { get; set; }

        public Stat[] stats;
        public Team team;
        
        public void UpdateName(string name)
        {
            Name = name;
        }

        public void CreateNew(string name, string link)
        {
            Trainer newTrainer = new Trainer();
            newTrainer.Name = name;
            newTrainer.Link = link;
            //Check that the link can be accessed
        }

        public int RollStat(string stat)
        {
            return 0;
        }
    }
}