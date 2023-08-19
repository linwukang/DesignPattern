using DesignPattern.StructuralPatterns.ProxyPattern.StaticProxy.ImageExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.ProxyPattern;
// 结构型模式

/// <summary>
/// 静态代理模式
/// 静态代理测试类
/// </summary>
[TestFixture]
public class StaticProxyPatternTest
{
    [Test]
    public void TestImageExample()
    {
        IImage image1 = new ProxyImage("image1.jpg");
        image1.Display();

        IImage image2 = new ProxyImage("image2.jpg");
        image2.Display();
        image2.Display();
    }
}