```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5608/22H2/2022Update)
AMD Ryzen 3 2200G with Radeon Vega Graphics, 1 CPU, 4 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method          | Mean     | Error    | StdDev   | Gen0      | Gen1      | Gen2     | Allocated |
|---------------- |---------:|---------:|---------:|----------:|----------:|---------:|----------:|
| &#39;Riok Mapperly&#39; | 22.56 ms | 0.451 ms | 1.140 ms | 1968.7500 | 1218.7500 | 312.5000 |  10.68 MB |
| AutoMapper      | 24.63 ms | 0.621 ms | 1.830 ms | 2031.2500 | 1281.2500 | 343.7500 |  11.92 MB |
