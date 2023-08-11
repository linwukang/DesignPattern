using DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
using NUnit.Framework;

namespace DesignPattern.CreationalPatterns.PrototypePattern;
// 创建型模式

/// <summary>
/// 原型模式
/// 测试类
/// </summary>
[TestFixture]
public class PrototypePatternTest
{
    [Test]
    public void TestShapeExample()
    {
        Shape? shape01 = ShapeCache.GetShape("1");
        Shape? shape02 = ShapeCache.GetShape("2");
        Shape? shape03 = ShapeCache.GetShape("3");

        shape01?.Draw();
        shape02?.Draw();
        shape03?.Draw();
    }
}