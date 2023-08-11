namespace DesignPattern.CreationalPatterns.SingletonPattern;
// 创建型模式

/// <summary>
/// 单例模式
/// 通过懒加载方式实现
/// 通过同步锁的方式保证线程安全
/// </summary>
public class SynchronizedLazySingleton
{
    private readonly string _content;

    private SynchronizedLazySingleton(string content) => _content = content;

    public void ShowContent() => Console.WriteLine(_content);

    private SynchronizedLazySingleton? _instance = null;

    public SynchronizedLazySingleton Instance
    {
        get
        {
            lock (typeof(SynchronizedLazySingleton))
            {
                if (_instance is null)
                {
                    _instance = new SynchronizedLazySingleton("线程安全懒加载单例");
                }

                return _instance;
            }
        }
    }


}