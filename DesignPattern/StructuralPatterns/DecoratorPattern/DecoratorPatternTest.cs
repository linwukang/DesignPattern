using DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.DecoratorPattern;
// 结构型模式

/// <summary>
/// 装饰器模式
/// 测试类
/// </summary>
[TestFixture]
public class DecoratorPatternTest
{
    [Test]
    public void TestShapeExample()
    {
        IShape circle = new Circle();
        ShapeDecorator redBorderCircle = new RedBorderShapeDecorator(new Circle());
        ShapeDecorator redBorderRectangle = new RedBorderShapeDecorator(new Rectangle());
        circle.Draw();
        redBorderCircle.Draw();
        redBorderRectangle.Draw();
    }
}