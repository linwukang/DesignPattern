namespace DesignPattern.StructuralPatterns.DecoratorPattern.ShapeExample;
// 结构型模式

/// <summary>
/// 装饰器模式
/// 圆形类
/// </summary>
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Circle.Draw() method.");
    }
}