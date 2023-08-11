namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// Shape 抽象工厂类
/// </summary>
public class ShapeFactory : AbstractFactory
{
    public override IColor? GetColor(string color)
    {
        return null;
    }

    public override IShape? GetShape(string shape)
    {
        return shape switch
        {
            "RECTANGLE" => new Rectangle(),
            "SQUARE" => new Square(),
            "CIRCLE" => new Circle(),
            _ => null
        };
    }
}