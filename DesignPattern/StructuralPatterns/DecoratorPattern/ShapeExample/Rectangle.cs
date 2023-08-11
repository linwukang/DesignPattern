namespace DesignPattern.StructuralPatterns.DecoratorPattern.ShapeExample;
// 结构型模式

/// <summary>
/// 装饰器模式
/// 矩形类
/// </summary>
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Rectangle.Draw() method.");
    }
}