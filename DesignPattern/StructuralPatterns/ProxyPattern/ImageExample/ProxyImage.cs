namespace DesignPattern.StructuralPatterns.ProxyPattern.ImageExample;
// 结构型模式

/// <summary>
/// 代理模式
/// 代理图片类
/// </summary>
public class ProxyImage : IImage
{
    private RealImage? _realImage;
    private readonly string _filename;

    public ProxyImage(string filename)
    {
        _filename = filename;
    }

    public void Display()
    {
        _realImage ??= new RealImage(_filename);
        _realImage.Display();
    }
}