using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Chair
    {
        private string type;
        private float height;
        private string color;
        private float width;
        private float weight;

        
        public string Type { get; set; }
        public float Height { get; set; }
        public string Color { get; set; }
        public float Width { get; set; }
        public float Weight { get; set; }

        public Chair(string type, float height, string color, float width, float weight) { }
        public Chair() { }
        public string printChair()
        {
            return ($"{this.type}, {this.height}, {this.color}, {this.width}, {this.weight}");
        }
    }
}
