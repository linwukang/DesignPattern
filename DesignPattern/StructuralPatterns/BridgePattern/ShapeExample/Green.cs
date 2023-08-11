namespace DesignPattern.StructuralPatterns.BridgePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 桥接模式
/// 绿色类
/// </summary>
public class Green : IColor
{
    public void Fill()
    {
        Console.WriteLine("Coloring with green color.");
    }
}