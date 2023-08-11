namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// Color 抽象工厂类
/// </summary>
public class ColorFactory : AbstractFactory
{
    public override IColor? GetColor(string color)
    {
        return color switch
        {
            "RED" => new Red(),
            "GREEN" => new Green(),
            "BLUE" => new Blue(),
            _ => null
        };
    }

    public override IShape? GetShape(string shape)
    {
        return null;
    }
}