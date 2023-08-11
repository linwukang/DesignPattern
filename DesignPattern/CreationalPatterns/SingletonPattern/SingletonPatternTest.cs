using DesignPattern.CreationalPatterns.SingletonPattern.Example;
using NUnit.Framework;

namespace DesignPattern.CreationalPatterns.SingletonPattern;
// 创建型模式

/// <summary>
/// 单例模式
/// 测试类
/// </summary>
[TestFixture]
public class SingletonPatternTest
{
    [Test]
    public void TestExample()
    {
        Singleton singleton01 = Singleton.Instance;
        singleton01.ShowContent();
     
        LazySingleton singleton02 = LazySingleton.Instance;
        singleton02.ShowContent();

        SynchronizedLazySingleton singleton03 = SynchronizedLazySingleton.Instance;
        singleton03.ShowContent();

        DclSynchronizedLazySingleton singleton04 = DclSynchronizedLazySingleton.Instance;
        singleton04.ShowContent();

    }
}