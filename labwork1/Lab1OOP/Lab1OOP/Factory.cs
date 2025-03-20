using Lab1OOP;
using System.Collections.Generic;
using System;

internal static class Factory
{
    private static Dictionary<string, Func<int, int, int, int, Figure>> _shapeCreators = new Dictionary<string, Func<int, int, int, int, Figure>>();

    static Factory()
    {
        RegisterShape("Эллипс", (x, y, width, height) => new Ellipse(x, y, width, height));
        RegisterShape("Круг", (x, y, width, height) => new Circle(x, y, width, width));
        RegisterShape("Прямоугольник", (x, y, width, height) => new Rectangle(x, y, width, height));
        RegisterShape("Линия", (x, y, x1, y1) => new Line (x, y, x1, y1));
        RegisterShape("Параллелограмм", (x, y, width, height) => new Parallelogram(x, y, width, height));
        RegisterShape("Квадрат", (x, y, width, height) => new Square(x, y, width, width));
    }
    
    public static void RegisterShape(string shapeType, Func<int, int, int, int, Figure> creator)
    {
        _shapeCreators[shapeType] = creator;
    }

    public static Figure CreateShape(string shapeType, int x, int y, int p1 = 0, int p2 = 0)
    {
        if (_shapeCreators.ContainsKey(shapeType))
        {
            return _shapeCreators[shapeType](x, y, p1, p2);
        }
        throw new ArgumentException($"Фигура '{shapeType}' не поддерживается.");
    }
}
