﻿namespace DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
// 创建型模式

/// <summary>
/// 工厂方法模式
/// 矩形类
/// </summary>
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Rectangle.Draw() method.");
    }
}