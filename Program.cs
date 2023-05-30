using System.Diagnostics;
using System.Security;
using System.Linq;
using System.Collections.Frozen;
using System.Text;
using System.Globalization;
using Bogus;
using System.Text.Json;
using System.Numerics;
using System.Runtime.Intrinsics;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.Reflection;

// Sample class that contains a function pointer field.
// ...

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



// ValidateOptionsResultBuilder builder = new ValidateOptionsResultBuilder();
// builder.AddError("Error: invalid operation code");
// builder.AddResult(ValidateOptionsResult.Fail("Invalid request parameters"));
// builder.AddError("Malformed link", "Url");

// // Build ValidateOptionsResult object has accumulating multiple errors.
// ValidateOptionsResult result = builder.Build();
// Console.WriteLine(result.FailureMessage);
// // Reset the builder to allow using it in new validation operation.
// builder.Clear();

// if(Vector512.IsHardwareAccelerated)
// {
//     Console.WriteLine("support");
// }

// if (Vector.IsHardwareAccelerated){
// var m1 = new Matrix4x4(
//             1.1f, 1.2f, 1.3f, 1.4f,
//             2.1f, 2.2f, 3.3f, 4.4f,
//             3.1f, 3.2f, 3.3f, 3.4f,
//             4.1f, 4.2f, 4.3f, 4.4f);

// var m2 = Matrix4x4.Transpose(m1);
// var mResult = Matrix4x4.Multiply(m1, m2);
// Console.WriteLine(mResult.ToString());
// }

  // var vectorBenchmark =  BenchmarkDotNet.Running.BenchmarkRunner.Run<VectorBenchmark>();
  // Console.ReadKey();
// if (Vector.IsHardwareAccelerated){
//   Console.WriteLine("support");
// }
// var v1 = new Vector2(0.1f,0.2f);
// var v2 = new Vector2(1.1f,2.2f);
// var res = v1+v2;
// Console.WriteLine(res);
  // var compositeSummary =  BenchmarkDotNet.Running.BenchmarkRunner.Run<XxHashBenchmark>();
  // Console.ReadKey();

//   var compositeSummary =  BenchmarkDotNet.Running.BenchmarkRunner.Run<CompositeBenchmark>();
//   Console.ReadKey();
// var fruit = new[] {"a{0}ple", "banana", "or{1}nge", "strawberry", "kiwi"};
// var faker = new Faker();

// List<string> randomStrings = Enumerable.Range(1,7)
//                        .Select(_ => faker.PickRandom(fruit))
//                        .ToList();

// var str =  JsonSerializer.Serialize(randomStrings);

// var _cf =  CompositeFormat.Parse(str);
       
// var res = string.Format(CultureInfo.InvariantCulture, _cf, 1, 10);
// Console.WriteLine(res);



//Console.Read();
// Instantiate a standalone .resources file from a stream.
 
//BogusDemo.BogusTest();

// var indexSummary =  BenchmarkDotNet.Running.BenchmarkRunner.Run<IndexOfAnyBenchmark>();
//  Console.ReadKey();

// Console.ReadKey();

 
// var forzenSummary = BenchmarkDotNet.Running.BenchmarkRunner.Run<FrozenDictionaryBenchmark>();

// ReadOnlySpan<char> text = "ABCDEFG";
// char[] thisRound = Random.Shared.GetItems(text, 31);
// thisRound.ToList().ForEach(r=>Console.Write(r));
// Console.WriteLine();
// int[] data = new int[]{1,2,3,4,5,6,7,8,9};
// Random.Shared.Shuffle(data);
// data.ToList().ForEach(r=>Console.Write(r));

// var value = new Pussy(2);
// var options = new JsonSerializerOptions();
// var text = JsonSerializer.Serialize(value,options);
// Console.Write(text);

// const string json = @"{ ""Meows"": ""3"" }";
// var pussy = JsonSerializer.Deserialize<Pussy>(json);
// Console.Write(pussy.Meows);

// var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower };
// var text = JsonSerializer.Serialize(new { FirstName = "fisrt",LastName="second" }, options); // { "property_name" : "value" }
// Console.Write(text);

// IDerived value = new DerivedImplement { Base = 0, Derived = 1 };
// var text = JsonSerializer.Serialize(value); // {"Base":0,"Derived":1}
// Console.Write(text);


// const string json = @"{ ""InitOnly"": "".NET"", ""Settable"": ""Rocks"" }";
// var tagLine1 = JsonSerializer.Deserialize<TagLine>(json);

// Console.WriteLine(tagLine1.InitOnly ?? "tagLine1.InitOnly is null");
// Console.WriteLine(tagLine1.Settable ?? "tagLine1.Settable is null");
 
// var tagLine2 = JsonSerializer.Deserialize<TagLine>(json, TagLineJsonContext.Default.TagLine);
// Console.WriteLine(tagLine2.InitOnly ?? "tagLine2.InitOnly is null");
// Console.WriteLine(tagLine2.Settable ?? "tagLine2.Settable is null");
// Console.ReadLine();
 
