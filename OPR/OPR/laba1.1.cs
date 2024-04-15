class Triangle
{
    private double ab, bc, ca, a, b, c, S, P, pP, Ha, Hb, Hc;

    public bool newtriangle()
    {
        try
        {
            Console.WriteLine("Сторона ab");
            ab = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона bc");
            bc = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона ca");
            ca = double.Parse(Console.ReadLine());
            Console.WriteLine("Угол a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Угол b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Угол c");
            c = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат");
        }
        if (ab < 0 || bc < 0 || ca < 0 || a < 0 || b < 0 || c < 0)
        {
            Console.WriteLine("Нельзя отрицательные!");
            ab = 0;
            bc = 0;
            ca = 0;
            a = 0;
            b = 0;
            c = 0;
            return false;
        }
        else if (ab == 0 || bc == 0 || ca == 0 || a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Нельзя нулевые значения!");
            ab = 0;
            bc = 0;
            ca = 0;
            a = 0;
            b = 0;
            c = 0;
            return false;
        }
        else if ((ab + bc > ca || ab + ca > bc || bc + ca > ab) && (a + b + c) == 180)
        {
            Console.WriteLine("Успешно! Такой треугольник существует");
            return true;
        }
        else
        {
            Console.WriteLine("Такого треугольника не существует");
            ab = 0;
            bc = 0;
            ca = 0;
            a = 0;
            b = 0;
            c = 0;
            return false;
        }
    }
    public double square()
    {
        pP = perimetr() / 2;
        S = Math.Sqrt(pP * (pP - ab) * (pP - bc) * (pP - ca));
        return S;
    }
    public double perimetr()
    {
        P = ab + bc + ca;
        return P;
    }
    public double ha()
    {
        Ha = square() * 2 / ab;
        return Ha;
    }
    public double hb()
    {
        Hb = square() * 2 / bc;
        return Hb;
    }
    public double hc()
    {
        Hc = square() * 2 / ca;
        return Hc;
    }
    public void type()
    {
        if (a == 90 || b == 90 || c == 90)
            Console.WriteLine("Треугольник прямоугольный");
        else if (a == b & b == c)
            Console.WriteLine("Треугольник равносторонний");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Треугольник равнобедренный");
        else
            Console.WriteLine("Обычный треугольник");
    }
}