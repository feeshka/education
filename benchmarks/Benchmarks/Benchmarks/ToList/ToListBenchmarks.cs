using BenchmarkDotNet.Attributes;
using System.Collections.Immutable;

namespace Benchmarks.ToList;

public class ToListBenchmarks
{
    private const int _count = 1_000_000;

    IEnumerable<int> Do(Func<IEnumerable<int>, IEnumerable<int>> function) =>
        function(function(Enumerable.Range(0, _count)));

    [Benchmark]
    public ImmutableArray<int> ToImmutableArray() => (ImmutableArray<int>)Do(x => x.ToImmutableArray());

    [Benchmark]
    public int[] ToArray() => (int[])Do(x => x.ToArray());

    [Benchmark]
    public List<int> ToList() => (List<int>)Do(x => x.ToList());

    [Benchmark]
    public IImmutableList<int> ToImmutableList() => (IImmutableList<int>)Do(x => x.ToImmutableList());
}
