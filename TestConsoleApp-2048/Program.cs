﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp_2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        Model model;

        void Start()
        {
            Model model = new Model(4);
            model.Start();
            while (true)
            {
                Show();
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.LeftArrow:
                        model.Left();
                        break;
                    case ConsoleKey.RightArrow:
                        model.Right();
                        break;
                    case ConsoleKey.UpArrow:
                        model.Up();
                        break;
                    case ConsoleKey.DownArrow:
                        model.Down();
                        break;
                    case ConsoleKey.Escape:
                        model.Start();
                        break;
                }
            }
        }

        void Show(Model model)
        { 
            for (int y=0; y<model.size; y++)
                for (int x=0; x<model.size; x++)
                {
                    Console.SetCursorPosition(x*5+5, y*2+2);
                    int number = model.GetMap(x,y);
                    Console.Write(number == 0 ? "  " : number.ToString() + "  ");
                }
            Console.WriteLine();
            if (model.isGameOver)
                Console.WriteLine("Geme Over");
            else
                Console.WriteLine("Still play");
        }
    }
}
