using System.Diagnostics;
using System.Security;
using System.Linq;
using System.Collections.Frozen;
using System.Text;
using System.Globalization;
using Bogus;
using System.Text.Json;

  var compositeSummary =  BenchmarkDotNet.Running.BenchmarkRunner.Run<XxHashBenchmark>();
  Console.ReadKey();

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
 
