namespace DesignPattern.CreationalPatterns.SingletonPattern;
// 创建型模式

/// <summary>
/// 单例模式
/// 通过懒加载方式实现
/// 通过双重校验锁的方式保证线程安全
/// </summary>
public class DclSynchronizedLazySingleton
{
    private readonly string _content;

    private DclSynchronizedLazySingleton(string content) => _content = content;

    public void ShowContent() => Console.WriteLine(_content);

    private DclSynchronizedLazySingleton? _instance = null;

    public DclSynchronizedLazySingleton Instance
    {
        get
        {
            // if (_instance is not null) return _instance;

            if (_instance is null)
            {
                lock (typeof(DclSynchronizedLazySingleton))
                {
                    if (_instance is null)
                    {
                        _instance = new DclSynchronizedLazySingleton("懒加载单例");
                    }
                }
            }

            return _instance;
        }
    }
}