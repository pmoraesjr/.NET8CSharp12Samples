using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sample01
{
    public class Customer
    {
        internal Customer(string id) => Id = id;
        [JsonInclude]
        internal string Id { get; set; }

        public string City { get; set; }

    }
}
