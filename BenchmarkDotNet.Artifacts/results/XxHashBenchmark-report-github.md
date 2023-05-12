``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
|     Method |   Max |        Mean |       Error |      StdDev |      Median |
|----------- |------ |------------:|------------:|------------:|------------:|
| **XxHashTest** |   **100** |    **254.1 ns** |     **4.19 ns** |     **5.88 ns** |    **252.2 ns** |
|   Sha1Test |   100 |  1,622.9 ns |    17.02 ns |    15.08 ns |  1,621.9 ns |
| Sha256Test |   100 |  2,559.3 ns |    49.33 ns |    46.14 ns |  2,549.8 ns |
| **XxHashTest** |  **1000** |    **288.5 ns** |     **5.82 ns** |    **14.28 ns** |    **285.4 ns** |
|   Sha1Test |  1000 |  3,249.4 ns |    40.71 ns |    36.09 ns |  3,251.0 ns |
| Sha256Test |  1000 |  7,109.3 ns |   115.56 ns |    96.50 ns |  7,099.9 ns |
| **XxHashTest** | **10000** |    **817.9 ns** |    **16.39 ns** |    **19.51 ns** |    **815.1 ns** |
|   Sha1Test | 10000 | 20,510.6 ns |   407.21 ns |   951.84 ns | 20,053.2 ns |
| Sha256Test | 10000 | 50,978.6 ns | 1,011.45 ns | 1,899.75 ns | 50,462.5 ns |
