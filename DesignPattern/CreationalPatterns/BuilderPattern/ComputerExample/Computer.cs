namespace DesignPattern.CreationalPatterns.BuilderPattern.ComputerExample;
// 创建型模式

/// <summary>
/// 建造者模式
/// 计算机抽象类
/// </summary>
public abstract class Computer
{
    public string? Board { get; set; }           // 主板
    
    public string? Display { get; set; }         // 显示屏

    public abstract string? Os { get; set; }     // 操作系统

    internal Computer() {}

    public override string ToString()
    {
        return $"Computer[Board: {Board}, Display: {Display}, Os: {Os}]";
    }
}