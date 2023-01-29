using BenchmarkDotNet.Attributes;

namespace LeetChallenges._1_TwoSum;

[MemoryDiagnoser]
public class TwoSumBenchmarks
{
    private readonly NumbersAndTarget[] _inputValues =
    {
        new(new[] { 2, 7, 11, 15 }, 9),
        new(new[] { 3, 2, 4 }, 6),
        new(new[] { 3, 3 }, 6),
        new(Enumerable.Range(1, (int)Math.Pow(10, 4)).Select(x => x % 10).ToArray(), 6)
    };

    private NumbersAndTarget _currentCase;

    [Params(1, 2, 3, 4)]
    public int BenchmarkCase;

    [GlobalSetup]
    public void Setup()
    {
        _currentCase = _inputValues[BenchmarkCase - 1];
    }

    [Benchmark]
    public int[] TwoSumV1_()
    {
        return TwoSumV1.Execute(_currentCase.numbers, _currentCase.target);
    }

    [Benchmark]
    public int[] TwoSumV2_()
    {
        return TwoSumV2.Execute(_currentCase.numbers, _currentCase.target);
    }

    private record struct NumbersAndTarget(int[] numbers, int target);
}