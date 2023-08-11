namespace DesignPattern.StructuralPatterns.BridgePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 桥接模式
/// 红色类
/// </summary>
public class Red : IColor
{
    public void Fill()
    {
        Console.WriteLine("Coloring with red color.");
    }
}