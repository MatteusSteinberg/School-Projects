using System;
using System.Collections.Generic;
using System.Text;

namespace h1spil.Classes
{
    public class Cowboy
    {
        public string Name { get; set; }

        public string State { get; set; }

        public double Easy()
        {
                var rnd = new Random(DateTime.Now.Millisecond);
                double timing = rnd.Next(250, 700);
                return timing;
        }
        public double Normal()
        {
                var rnd = new Random(DateTime.Now.Millisecond);
                double timing = rnd.Next(270, 500);
                return timing;
        }
        public double Hard()
        { 
                var rnd = new Random(DateTime.Now.Millisecond);
                double timing = rnd.Next(200, 300);
                return timing;
        }
        public double Impossible()
        {
                var rnd = new Random(DateTime.Now.Millisecond);
                double timing = rnd.Next(220, 270);
                return timing;
        }
    }
}
