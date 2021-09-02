using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_MVP.Model
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Year} - {Color} - {Transmission}";
        }
    }
}
