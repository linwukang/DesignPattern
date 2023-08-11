namespace DesignPattern.CreationalPatterns.BuilderPattern.ComputerExample;
// 创建型模式

/// <summary>
/// 建造者模式
/// 计算机建造者抽象类
/// </summary>
public abstract class ComputerBuilder
{
    public abstract void BuildBoard(String board);
    public abstract void BuildDisplay(String display);
    public abstract void BuildOs();
    public abstract Computer Build();
}