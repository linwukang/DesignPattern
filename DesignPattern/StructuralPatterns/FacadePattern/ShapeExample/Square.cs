namespace DesignPattern.StructuralPatterns.FacadePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 正方形类
/// </summary>
public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Square.Draw() method.");
    }
}