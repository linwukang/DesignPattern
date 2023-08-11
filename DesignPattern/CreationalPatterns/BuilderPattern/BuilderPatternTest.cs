using DesignPattern.CreationalPatterns.BuilderPattern.ComputerExample;
using NUnit.Framework;

namespace DesignPattern.CreationalPatterns.BuilderPattern;
// 创建型模式

/// <summary>
/// 建造者模式
/// 测试类
/// </summary>
[TestFixture]
public class BuilderPatternTest
{
    [Test]
    public void TestComputerExample()
    {
        ComputerBuilder builder = new MacBookComputerBuilder();
        var director = new ComputerDirector(builder);
        director.Construct("华硕PRIME H610M-A D4", "Redmi 1A");
        var computer = builder.Build();
        Console.WriteLine(computer);
    }
}