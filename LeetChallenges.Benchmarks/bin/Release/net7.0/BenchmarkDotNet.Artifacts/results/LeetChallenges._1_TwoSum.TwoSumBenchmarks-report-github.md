``` ini

BenchmarkDotNet=v0.13.4, OS=ubuntu 22.10
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 12 physical cores
.NET SDK=7.0.102
  [Host]     : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2


```
|    Method | BenchmarkCase |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|---------- |-------------- |----------:|----------:|----------:|-------:|----------:|
| **TwoSumV1_** |             **1** |  **8.698 ns** | **0.0730 ns** | **0.0647 ns** | **0.0034** |      **32 B** |
| TwoSumV2_ |             1 | 38.615 ns | 0.1647 ns | 0.1541 ns | 0.0255 |     240 B |
| **TwoSumV1_** |             **2** | **11.291 ns** | **0.0908 ns** | **0.0850 ns** | **0.0034** |      **32 B** |
| TwoSumV2_ |             2 | 46.065 ns | 0.4484 ns | 0.4194 ns | 0.0255 |     240 B |
| **TwoSumV1_** |             **3** |  **8.888 ns** | **0.1237 ns** | **0.1157 ns** | **0.0034** |      **32 B** |
| TwoSumV2_ |             3 | 40.038 ns | 0.5437 ns | 0.4540 ns | 0.0255 |     240 B |
