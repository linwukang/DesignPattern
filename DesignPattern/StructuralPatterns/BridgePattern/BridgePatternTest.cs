using DesignPattern.StructuralPatterns.BridgePattern.ShapeExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.BridgePattern;
// 结构型模式

/// <summary>
/// 桥接模式
/// 测试类
/// </summary>
[TestFixture]
public class BridgePatternTest
{
    [Test]
    public void TestShapeExample()
    {
        IColor red = new Red();
        IColor green = new Green();

        Shape redCircle = new Circle(red);
        Shape greenCircle = new Circle(green);
        Shape redSquare = new Square(red);
        Shape greenSquare = new Square(green);

        redCircle.Draw();
        greenCircle.Draw();
        redSquare.Draw();
        greenSquare.Draw();
    }
}