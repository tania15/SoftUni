﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food = 0;
        public string Name { get; private set; }

        public int Age { get; private set; }
        public string Group { get; private set; }
        public int Food { get; set; }

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            //Food = 0;
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
