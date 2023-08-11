﻿namespace DesignPattern.StructuralPatterns.FacadePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 外观类
/// </summary>
public class ShapeMaker
{
    private readonly IShape _circle;
    private readonly IShape _rectangle;
    private readonly IShape _square;

    public ShapeMaker()
    {
        _circle = new Circle();
        _rectangle = new Rectangle();
        _square = new Square();
    }

    public void DrawCircle()
    {
        _circle.Draw();
    }

    public void DrawRectangle()
    {
        _rectangle.Draw();
    }

    public void DrawSquare()
    {
        _square.Draw();
    }
}