﻿namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 圆形类
/// </summary>
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Circle.Draw() method.");
    }
}