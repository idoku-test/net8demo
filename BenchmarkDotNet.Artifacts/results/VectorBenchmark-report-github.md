``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2965/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=8.0.100-preview.3.23178.7
  [Host]     : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.17408), X64 RyuJIT AVX2


```
|    Method |     Mean |     Error |    StdDev |   Median |
|---------- |---------:|----------:|----------:|---------:|
|  ArraySum | 5.402 μs | 0.1076 μs | 0.2383 μs | 5.347 μs |
|   ListSum | 6.171 μs | 0.0956 μs | 0.0798 μs | 6.171 μs |
| VectorSum | 3.358 μs | 0.1036 μs | 0.2906 μs | 3.274 μs |
