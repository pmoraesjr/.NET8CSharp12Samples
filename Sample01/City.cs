using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public struct City
    {
        public City(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }

        public string Name { get; set; }
        public string Country { get; set; }


    }




}
