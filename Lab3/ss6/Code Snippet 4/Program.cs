﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippet_4
{
    class TestProgram
    {
        void Count (int boys, int girls)
        {
            Console.WriteLine(boys + girls);
        }
        static void Main(string[] args)
        {
            TestProgram objTest = new TestProgram();
            objTest.Count(boys: 16, girls: 24);
        }
    }
}
