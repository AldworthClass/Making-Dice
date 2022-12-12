﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Dice
{
    public class Die
    {
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public Die(int roll)
        {
            _generator = new Random();
            _roll = roll;
        }

        public int Roll { get { return _roll; } }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void DrawRoll()
        {
            switch (_roll)
            {
                case 1:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|   |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|   |");
                    Console.WriteLine(" ---");
                    break;



            }
        }
    }
}
