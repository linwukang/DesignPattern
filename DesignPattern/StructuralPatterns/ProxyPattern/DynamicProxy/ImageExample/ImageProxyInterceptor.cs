using Castle.DynamicProxy;

namespace DesignPattern.StructuralPatterns.ProxyPattern.DynamicProxy.ImageExample;

public class ImageProxyInterceptor : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        Console.WriteLine("Before");
        invocation.Proceed();
        Console.WriteLine("After");
    }
}