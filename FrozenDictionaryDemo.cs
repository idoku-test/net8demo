using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;

public class FrozenDictionaryBenchmark
{
    private string _path;
     
    [Params(10, 100,1000,10000)]
    public int MaxRoutes { get; set; }

    private static Dictionary<string,string> _attemptDict;

    private static FrozenDictionary<string,string> _attemptFrozenDict;

    [GlobalSetup]
    public void Setup()
    {
        var routeMap = CreateRouteMap(MaxRoutes);
        _path = $"/route{MaxRoutes - 1}/some/more/things/in/the/path";
        _attemptDict = CreateRouteMap(MaxRoutes);
        _attemptFrozenDict = CreateRouteMap(MaxRoutes).ToFrozenDictionary(optimizeForReading:true);
    }

    [Benchmark]
    public void FrozenDictionary()
    {
       _attemptFrozenDict.TryGetValue(_path,out var result);
    }

    [Benchmark]
    public void Dicitonary()
    {
        _attemptDict.TryGetValue(_path,out var result);
    }

 private static Dictionary<string, string> CreateRouteMap(int maxRoutes)
        => Enumerable
            .Range(0, maxRoutes)
            .ToDictionary(i => $"route{i}", i => $"route{i}endpoint");

//   private static FrozenDictionary<string, string> CreateFrozenRouteMap(int maxRoutes)
//         => Enumerable
//             .Range(0, maxRoutes)
//             .ToDictionary(i => $"route{i}", i => $"route{i}endpoint").ToFrozenDictionary(optimizeForReading:true);


}

 