namespace DesignPattern.CreationalPatterns.BuilderPattern.ComputerExample;
// 创建型模式

/// <summary>
/// 建造者模式
/// Mac Book 计算机
/// </summary>
public class MacBookComputer : Computer
{
    public override string? Os
    {
        get => "Mac OS X 12";
        set { }
    }

    internal MacBookComputer() {}
}