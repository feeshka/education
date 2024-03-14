using BenchmarkDotNet.Running;
using Benchmarks.ToList;

BenchmarkRunner.Run<ToListBenchmarks>();

Console.ReadLine();
