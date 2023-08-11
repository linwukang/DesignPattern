namespace DesignPattern.CreationalPatterns.SingletonPattern;
// 创建型模式

/// <summary>
/// 单例模式
/// 通过懒加载方式实现
/// 线程不安全
/// </summary>
public class LazySingleton
{
    private readonly string _content;

    private LazySingleton(string content) => _content = content;

    public void ShowContent() => Console.WriteLine(_content);

    private LazySingleton? _instance = null;

    /// <summary>
    /// 通过此静态属性可以获取类的实例
    /// 在第一次调用时创建实例对象
    /// 该属性是线程不安全的
    /// </summary>
    public LazySingleton Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new LazySingleton("懒加载单例");
            }

            return _instance;
        }
    }
}