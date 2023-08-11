namespace DesignPattern.CreationalPatterns.BuilderPattern.ComputerExample;
// 创建型模式

/// <summary>
/// 建造者模式
/// Mac Book计算机建造者类
/// </summary>
public class MacBookComputerBuilder : ComputerBuilder
{
    private Computer _computer = new MacBookComputer();

    public override void BuildBoard(string board)
    {
        _computer.Board = board;
    }

    public override void BuildDisplay(string display)
    {
        _computer.Display = display;
    }

    public override void BuildOs()
    {
    }

    public override Computer Build()
    {
        return _computer;
    }
}