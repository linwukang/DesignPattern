using DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
using NUnit.Framework;

namespace DesignPattern.CreationalPatterns.FactoryMethodPattern;
// 创建型模式

/// <summary>
/// 工厂方法模式
/// 测试类
/// </summary>
[TestFixture]
public class FactoryMethodPatternTest
{
    [Test]
    public void TestShapeExample()
    {
        ShapeFactory factory = new ShapeFactory();
        var rectangle = factory.GetShape("RECTANGLE");
        var circle = factory.GetShape("CIRCLE");
        var square = factory.GetShape("SQUARE");

        rectangle?.Draw();
        circle?.Draw();
        square?.Draw();
    }
}