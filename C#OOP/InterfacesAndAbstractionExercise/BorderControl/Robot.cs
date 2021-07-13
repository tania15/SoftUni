using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IId
    {
        private string model;
        private string id;

        public string Model { get; private set; }

        public string Id { get; private set; }

        public Robot(string mode, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
