﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRewrite

{
    class Program
    {
        static void Main(string[] args)
        {
            View netflix = new View();
            netflix.printList();
            Console.ReadKey();
        }
    }
}
