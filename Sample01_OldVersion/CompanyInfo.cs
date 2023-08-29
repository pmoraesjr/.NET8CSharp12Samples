using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sample01
{
    class CompanyInfo
    {
        public required string CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
    }

    class CustomerInfo
    {
        public string CustomerName { set; get; } = "Anonymous";
        public CompanyInfo Company { get; } = new() { CompanyName = "N/A", PhoneNumber = "N/A" };
    }
}
