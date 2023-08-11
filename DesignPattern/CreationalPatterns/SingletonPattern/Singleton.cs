namespace DesignPattern.CreationalPatterns.SingletonPattern;
// 创建型模式

/// <summary>
/// 单例模式
/// </summary>
public class Singleton
{
    private readonly string _content;

    private Singleton(string content) => _content = content;

    public void ShowContent() => Console.WriteLine(_content);

    /// <summary>
    /// 通过此静态属性可以获取类的实例
    /// </summary>
    public static Singleton Instance { get; } = new("单例");
}