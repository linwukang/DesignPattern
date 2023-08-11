using DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
using NUnit.Framework;

namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 测试类
/// </summary>
[TestFixture]
public class AbstractFactoryPatternTest
{
    [Test]
    public void TestShapeColorExample()
    {
        AbstractFactory? shapeFactory = FactoryProducer.GetFactory("SHAPE");
        AbstractFactory? colorFactory = FactoryProducer.GetFactory("COLOR");

        IShape? rectangle = shapeFactory?.GetShape("RECTANGLE");
        IShape? circle = shapeFactory?.GetShape("CIRCLE");
        IShape? square = shapeFactory?.GetShape("SQUARE");

        IColor? red = colorFactory?.GetColor("RED");
        IColor? green = colorFactory?.GetColor("GREEN");
        IColor? blue = colorFactory?.GetColor("BLUE");

        rectangle?.Draw();
        circle?.Draw();
        square?.Draw();

        red?.Fill();
        green?.Fill();
        blue?.Fill();
    }
}