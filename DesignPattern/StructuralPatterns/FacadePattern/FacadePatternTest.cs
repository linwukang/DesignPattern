using DesignPattern.StructuralPatterns.FacadePattern.ShapeExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.FacadePattern;
// 结构型模式

/// <summary>
/// 外观模式
/// 测试类
/// </summary>
[TestFixture]
public class FacadePatternTest
{
    [Test]
    public void TestShapeExample()
    {
        var shapeMaker = new ShapeMaker();
        shapeMaker.DrawCircle();
        shapeMaker.DrawRectangle();
        shapeMaker.DrawSquare();
    }
}