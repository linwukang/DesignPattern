using DesignPattern.StructuralPatterns.ProxyPattern.ImageExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.ProxyPattern;
// 结构型模式

/// <summary>
/// 代理模式
/// 测试类
/// </summary>
[TestFixture]
public class ProxyPatternTest
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