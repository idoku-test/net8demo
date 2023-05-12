using System.Buffers;
using System.Globalization;
using System.Text;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Bogus;

using static BogusDemo;

public class CompositeBenchmark
{
// preprocess the format string statically at startup

static CompositeFormat _cf;
static string _str;

 [Params(10, 100)]
    public int Max { get; set; }

  [GlobalSetup]
    public void Setup()
    {
          var fruit = new[] {"a{0}ple", "banana", "or{1}nge", "strawberry", "kiwi"};
          var faker = new Faker();

List<string> randomStrings = Enumerable.Range(1,Max)
                       .Select(_ => faker.PickRandom(fruit))
                       .ToList();
          var rd = JsonSerializer.Serialize(randomStrings);
          _str = rd;
          _cf =  CompositeFormat.Parse(rd);
       
         
    }

[Benchmark]
public void CFParse()
{
     GetCFMessage(1,10);
}

[Benchmark]
public void StrParse(){
    GetMessage(1,10);
}
 static string GetCFMessage(int min, int max) =>
    string.Format(CultureInfo.InvariantCulture, _cf, min, max);

 static string GetMessage(int min, int max) =>
    string.Format(CultureInfo.InvariantCulture, _cf, min, max);

 
 public static string LoadJson()
    {
        using (StreamReader r = new StreamReader(@".\Resources\res.json"))
        {
            string json = r.ReadToEnd();
            Console.WriteLine(json);
            return json;
        }
    }
 }