
using Sample01;
using System.Text.Json;


//Sample01.01
//Console.WriteLine(JsonSerializer.Serialize(new object[] { Half.MaxValue }));
//Console.WriteLine(JsonSerializer.Serialize(new object[] { Int128.MaxValue }));
//Console.WriteLine(JsonSerializer.Serialize(new object[] { UInt128.MaxValue }));




//Sample01.02
//string jsonResult = JsonSerializer.Serialize(new Customer("1"));
//Console.WriteLine(jsonResult);

//Sample01.03
//IDerived value = new DerivedImplement { Base = 0, Derived = 1 };
//Console.WriteLine(JsonSerializer.Serialize(value)); 
// {"Base":0,"Derived":1}

//Sample01.04
//var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower }; 
//Console.WriteLine(JsonSerializer.Serialize(new { CustomerName = "Customer" }, options));
//{"customer_name":"Customer"}

//Sample01.05
//var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower };
//Console.WriteLine(JsonSerializer.Serialize(new { CustomerName = "Customer" }, options));
//{"customer-name":"Customer"}

