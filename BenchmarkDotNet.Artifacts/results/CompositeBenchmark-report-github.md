``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
|   Method | Max |        Mean |     Error |    StdDev |      Median |
|--------- |---- |------------:|----------:|----------:|------------:|
|  **CFParse** |  **10** |    **91.44 ns** |  **2.916 ns** |  **8.368 ns** |    **89.27 ns** |
| StrParse |  10 |   140.64 ns |  5.928 ns | 16.425 ns |   138.90 ns |
|  **CFParse** | **100** |   **904.11 ns** | **23.082 ns** | **67.696 ns** |   **875.03 ns** |
| StrParse | 100 | 1,042.19 ns | 17.939 ns | 22.030 ns | 1,033.46 ns |
