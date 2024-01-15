BenchmarkDotNet v0.13.10, Windows 10 (10.0.19044.3086/21H2/November2021Update)
Intel Core i5-7400 CPU 3.00GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
[Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2 [AttachedDebugger]
DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2

**Глоссарий**

*ns* - наносекунды
*us* - микросекунды
*ms* - миллисекунды


**Summary 1_000 elements**

| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| ToImmutableArray |    803.2 ns |  15.79 ns |  19.97 ns |
| ToArray          |  1,103.5 ns |  21.91 ns |  34.75 ns |
| ToList           |  2,258.6 ns |  44.15 ns |  71.30 ns |
| ToImmutableList  | 19,073.1 ns | 372.37 ns | 382.39 ns |

**Summary 10_000 elements**

| Method           | Mean       | Error     | StdDev    |
|----------------- |-----------:|----------:|----------:|
| ToImmutableArray |   6.939 us | 0.1385 us | 0.1595 us |
| ToArray          |  10.281 us | 0.1973 us | 0.2272 us |
| ToList           |  20.868 us | 0.3568 us | 0.3818 us |
| ToImmutableList  | 227.235 us | 4.3897 us | 4.6969 us |

**Summary 1_000_000 elements**

| Method           | Mean       | Error     | StdDev    |
|----------------- |-----------:|----------:|----------:|
| ToImmutableArray |   2.588 ms | 0.0446 ms | 0.0438 ms |
| ToArray          |   4.173 ms | 0.0853 ms | 0.2501 ms |
| ToList           |   4.455 ms | 0.0886 ms | 0.2426 ms |
| ToImmutableList  | 109.258 ms | 1.9336 ms | 2.3746 ms |

**Summary 10_000_000 elements**

| Method           | Mean         | Error      | StdDev     |
|----------------- |-------------:|-----------:|-----------:|
| ToImmutableArray |     7.597 ms |  0.1413 ms |  0.1451 ms |
| ToArray          |    13.351 ms |  0.2663 ms |  0.2849 ms |
| ToList           |    25.910 ms |  0.5080 ms |  0.6424 ms |
| ToImmutableList  | 1,366.251 ms | 26.6257 ms | 29.5944 ms |


*TODO: Изучить исходники, дописать обоснование - почему такая скорость.*
