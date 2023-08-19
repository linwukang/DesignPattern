using Castle.DynamicProxy;
using System.Reflection;
using System.Reflection.Emit;
using NUnit.Framework.Constraints;

namespace DesignPattern.StructuralPatterns.ProxyPattern.DynamicProxy.ImageExample;
// 结构型模式

/// <summary>
/// 动态代理模式
/// 动态代理图片类工厂类
/// </summary>
public class ImageProxyFactory
{
    private readonly IImage _image;
    public ImageProxyFactory(IImage image)
    {
        _image = image;
    }

    public IImage GetImageProxy()
    {
        var generator = new ProxyGenerator();
        var image =
            generator.CreateInterfaceProxyWithTarget(
                _image, new ImageProxyInterceptor());
        return image;
    }
}