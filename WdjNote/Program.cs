﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WdjNote_01.expriment1;


namespace WdjNote_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Show01.ShowMainMenu();
            int i = int.Parse(System.Console.ReadLine());
            switch(i)
            {
                case 1: 
                    Show01.CreateFileMenu();
                    break;
                case 2:
                    Show01.OpenFileMenu();
                    break;
            }

        }
    }
}
