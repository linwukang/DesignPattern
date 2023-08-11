namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 工厂创造器类
/// </summary>
public class FactoryProducer
{
    public static AbstractFactory? GetFactory(string choice)
    {
        return choice switch
        {
            "SHAPE" => new ShapeFactory(),
            "COLOR" => new ColorFactory(),
            _ => null
        };
    }
}