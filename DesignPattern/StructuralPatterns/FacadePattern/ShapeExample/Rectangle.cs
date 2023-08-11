namespace DesignPattern.StructuralPatterns.FacadePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 矩形类
/// </summary>
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Rectangle.Draw() method.");
    }
}