namespace DesignPattern.StructuralPatterns.ProxyPattern.DynamicProxy.ImageExample;
// 结构型模式

/// <summary>
/// 动态代理模式
/// 真实图片类
/// </summary>
public class RealImage : IImage
{
    private readonly string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading image from disk: {_filename}");
    }


    public void Display()
    {
        Console.WriteLine($"Displaying image: {_filename}");
    }
}