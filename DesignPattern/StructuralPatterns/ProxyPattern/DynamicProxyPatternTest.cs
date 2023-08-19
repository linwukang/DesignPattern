using DesignPattern.StructuralPatterns.ProxyPattern.DynamicProxy.ImageExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.ProxyPattern;
// 结构型模式

/// <summary>
/// 动态代理测试类
/// </summary>
[TestFixture]
public class DynamicProxyPatternTest
{
    [Test]
    public void TestImageExample()
    {
        var image1 = new RealImage("image1.jpg");
        image1.Display();

        var factory = new ImageProxyFactory(image1);

        var image2 = factory.GetImageProxy();
        image2.Display();
    }
}