
using Sample01;
using System.IO.Compression;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
//using static System.Runtime.InteropServices.JavaScript.JSType;



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

//Sample01.06
//CustomerInfo customer = JsonSerializer.Deserialize<CustomerInfo>("""{"CustomerName":"Paulo","Company":{"CompanyName":"Nearsure"}}""")!;

//Console.WriteLine(JsonSerializer.Serialize(customer));

//{"CustomerName":"Paulo","Company":{"CompanyName":"Nearsure","PhoneNumber":"N/A"}}


//Sample01.07
/*
    ZipFile.CreateFromDirectory(string sourceDirectoryName, Stream destination);
    ZipFile.CreateFromDirectory(string sourceDirectoryName, Stream destination, CompressionLevel compressionLevel, bool includeBaseDirectory);
    ZipFile.CreateFromDirectory(string sourceDirectoryName, Stream destination, CompressionLevel compressionLevel, bool includeBaseDirectory, Encoding? entryNameEncoding);

    ZipFile.ExtractToDirectory(Stream source, string destinationDirectoryName) { }
    ZipFile.ExtractToDirectory(Stream source, string destinationDirectoryName, bool overwriteFiles) { }
    ZipFile.ExtractToDirectory(Stream source, string destinationDirectoryName, Encoding? entryNameEncoding) { }
    ZipFile.ExtractToDirectory(Stream source, string destinationDirectoryName, Encoding? entryNameEncoding, bool overwriteFiles) { }
*/

/*
//Sample 01.08
static void Main()
{ 
}

FieldInfo fieldInfo = typeof(UClass).GetField(nameof(UClass._fp));

// Obtain the function pointer type from a field.
Type fpType = fieldInfo.FieldType;

// New methods to determine if a type is a function pointer.
Console.WriteLine($"IsFunctionPointer: {fpType.IsFunctionPointer}");
Console.WriteLine($"IsUnmanagedFunctionPointer: {fpType.IsUnmanagedFunctionPointer}");

// New methods to obtain the return and parameter types.
Console.WriteLine($"Return type: {fpType.GetFunctionPointerReturnType()}");

foreach (Type parameterType in fpType.GetFunctionPointerParameterTypes())
{
    Console.WriteLine($"Parameter type: {parameterType}");
}

// Access to custom modifiers and calling conventions requires a "modified type".
Type modifiedType = fieldInfo.GetModifiedFieldType();

// A modified type forwards most members to its underlying type.
Type normalType = modifiedType.UnderlyingSystemType;

// New method to obtain the calling conventions.
foreach (Type callConv in modifiedType.GetFunctionPointerCallingConventions())
{
    Console.WriteLine($"Calling convention: {callConv}");
}

// New method to obtain the custom modifiers.
foreach (Type modreq in modifiedType.GetFunctionPointerParameterTypes()[0].GetRequiredCustomModifiers())
{
    Console.WriteLine($"Required modifier for first parameter: {modreq}");
}

*/


//C# 12 Samples

//var IncrementBy = (int source, int increment = 1) => source + increment;
//Console.WriteLine(IncrementBy(5)); // 6
//Console.WriteLine(IncrementBy(5, 2)); // 7


//Sample 02.02
//using ArrayWithAlias = (int x, int y, int z);

//var x = new ArrayWithAlias(10, 20, 30);



/*
var buffer = new Buffer();
for (int i = 0; i < 10; i++)
{
    buffer[i] = i;
}

foreach (var i in buffer)
{
    Console.WriteLine(i);
}

[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int _element0;
}

*/