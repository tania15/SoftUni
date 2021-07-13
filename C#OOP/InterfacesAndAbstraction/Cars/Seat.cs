using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Color} {this.GetType().Name} {Model}" + Environment.NewLine + this.Start() + Environment.NewLine + this.Stop();
        }
    }
}
