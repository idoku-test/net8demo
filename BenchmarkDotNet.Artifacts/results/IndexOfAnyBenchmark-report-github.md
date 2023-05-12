``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
| Method | Max |      Mean |     Error |    StdDev |
|------- |---- |----------:|----------:|----------:|
|    **Old** |  **10** | **10.395 ns** | **0.2454 ns** | **0.6021 ns** |
|    New |  10 |  5.787 ns | 0.0979 ns | 0.0818 ns |
|    **Old** |  **20** | **10.585 ns** | **0.2454 ns** | **0.1916 ns** |
|    New |  20 |  6.005 ns | 0.1092 ns | 0.1021 ns |
