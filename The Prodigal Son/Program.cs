using System;
using System.Collections.Generic;
using System.Linq;
using The_Prodigal_Son;

namespace The_Prodigal_Son
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}