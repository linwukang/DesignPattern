namespace DesignPattern.StructuralPatterns.FacadePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 圆形类
/// </summary>
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Circle.Draw() method.");
    }
}