class Program
{
    static void Main()
    {
        try
        {
            //Лабораторная 8, задание 1:
            /*
            Triangle triangle = new Triangle();
            if (triangle.newtriangle() == true)
            {
                Console.WriteLine($"Периметр: {triangle.perimetr()}");
                Console.WriteLine($"Площадь: {triangle.square()}");
                Console.WriteLine($"Высота HA: {triangle.ha()}");
                Console.WriteLine($"Высота HB: {triangle.hb()}");
                Console.WriteLine($"Высота HC: {triangle.hc()}");
                triangle.type();
            }
            */

            //Лабораторная 8, задание 2:
            /*
            BitString a = new BitString();
            Console.WriteLine($"Low: ");
            a.Low = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"Hight: ");
            a.High = Convert.ToUInt64(Console.ReadLine());
            BitString b = new BitString();
            Console.WriteLine($"Low: ");
            b.Low = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"Hight: ");
            b.High = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine($"And: {a.And(b)}");
            Console.WriteLine($"Or: {a.Or(b)}");
            Console.WriteLine($"Xor: {a.Xor(b)}");
            Console.WriteLine($"Not: {a.Not()}");
            Console.WriteLine($"ShiftLeft: {a.shiftleft(3)}");
            Console.WriteLine($"ShoftRight: {a.shiftright(4)}");
            */
        }
        catch (FormatException) { Console.WriteLine("не верный формат"); }
        catch (OverflowException) { Console.WriteLine("не верный ввод"); }

        //Лабораторная 9:
        /*
        try
        {
            Console.WriteLine("Введите путь для создания файла:");
            string path = Console.ReadLine();
            doc d = new doc();
            d.create(path);

            Console.WriteLine("Что записать в файл: ");
            string text = Console.ReadLine();
            d.write(path, text);

            Console.WriteLine("Куда скопировать файл:");
            string newpath = Console.ReadLine();
            d.copy(path, newpath);

            Console.WriteLine("где удалить файл:");
            newpath = Console.ReadLine();
            d.del(newpath);

            Console.WriteLine("Куда перенести файл:");
            string anotherpath = Console.ReadLine();
            d.move(path, anotherpath);

            crypto c = new crypto();
            Console.WriteLine("Какой файл зашифровать:");
            path = Console.ReadLine();
            c.code(path);

            Console.WriteLine("Какой файл дешифровать:");
            newpath = Console.ReadLine();
            c.encode(path, newpath);
        }
        catch(DirectoryNotFoundException) { Console.WriteLine("Путь не найден"); }
        catch(FileNotFoundException) { Console.WriteLine("Файла не существует"); }
        catch(IOException) { Console.WriteLine("Файл уже существует"); }
        catch (ArgumentException) { Console.WriteLine("Не верный формат"); }
        */
    }
}