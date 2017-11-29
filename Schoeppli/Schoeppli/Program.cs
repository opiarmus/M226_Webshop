﻿using Schoeppli.Controller;
using Schoeppli.Generic;
using Schoeppli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoeppli
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonController pControl = new PersonController();
            ProduktController pkc = new ProduktController();

            pControl.InitializePeople();
            pControl.WriteData();
            pControl.ReadData();
            Console.WriteLine("########################################");
            pControl.PrintPeople();
            Console.WriteLine("########################################");

            pkc.InitialiseProducts();
            pkc.WriteData();
            pkc.ReadData();
            Console.WriteLine("########################################");
            pkc.PrintProdukte();
            Console.WriteLine("########################################");

        }
    }
}
