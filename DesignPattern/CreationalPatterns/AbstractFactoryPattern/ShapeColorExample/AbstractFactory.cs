namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 抽象工厂类
/// </summary>
public abstract class AbstractFactory
{
    public abstract IColor? GetColor(string color);
    public abstract IShape? GetShape(string shape);
}