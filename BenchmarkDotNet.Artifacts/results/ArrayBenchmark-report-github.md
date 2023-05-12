``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
|           Method | MaxRoutes |      Mean |     Error |    StdDev |    Median |
|----------------- |---------- |----------:|----------:|----------:|----------:|
| **FrozenDictionary** |        **10** |  **3.093 ns** | **0.1879 ns** | **0.5391 ns** |  **2.859 ns** |
|       Dicitonary |        10 | 17.451 ns | 0.3745 ns | 0.6657 ns | 17.256 ns |
| **FrozenDictionary** |       **100** |  **3.341 ns** | **0.1062 ns** | **0.2375 ns** |  **3.274 ns** |
|       Dicitonary |       100 | 19.832 ns | 0.6614 ns | 1.9293 ns | 19.389 ns |
| **FrozenDictionary** |      **1000** |  **3.306 ns** | **0.1038 ns** | **0.1313 ns** |  **3.288 ns** |
|       Dicitonary |      1000 | 18.104 ns | 0.3947 ns | 0.6485 ns | 18.019 ns |
| **FrozenDictionary** |     **10000** |  **4.168 ns** | **0.4412 ns** | **1.2871 ns** |  **3.753 ns** |
|       Dicitonary |     10000 | 18.419 ns | 0.4009 ns | 0.6242 ns | 18.290 ns |
