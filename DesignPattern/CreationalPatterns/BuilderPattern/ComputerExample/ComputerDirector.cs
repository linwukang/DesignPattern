namespace DesignPattern.CreationalPatterns.BuilderPattern.ComputerExample;
// 创建型模式

/// <summary>
/// 建造者模式
/// 计算机的具体建造
/// </summary>
public class ComputerDirector
{
    private readonly ComputerBuilder _builder;

    public ComputerDirector(ComputerBuilder builder)
    {
        _builder = builder;
    }

    public void Construct(string board, string display)
    {
        _builder.BuildBoard(board);
        _builder.BuildDisplay(display);
        _builder.BuildOs();
    }
}