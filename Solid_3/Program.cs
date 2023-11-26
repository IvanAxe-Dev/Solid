using System;

//Порушено принцип LSP(Liskov Substitution Principle), що означає таке наслідування підкласів від базових класів,
//щоб при заміні підкласу на базовий клас, програма працює коректно. У випадку, коли квадрат наслідується від прямокутника
//такого досягти неможливо, оскільки в них різні означення площі.
//Для того, щоб це виправити, скористаємось означенням базового абстрактного класу Shape.
abstract class Shape
{
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public override int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Square() { Side = 5 };
        Console.WriteLine(shape.GetArea());

        shape = new Rectangle() { Width = 5, Height = 10 };
        Console.WriteLine(shape.GetArea());
        //В оригіналі відповідь 100, оскільки value = 10; base.Height = value; base.Width = value; 
        Console.ReadKey();
    }
}

//using System;

//class Rectangle
//{
//    public virtual int Width { get; set; }
//    public virtual int Height { get; set; }
//    public int GetRectangleArea()
//    {
//        return Width * Height;
//    }
//}

//квадрат наслідується від прямокутника!!!
//class Square : Rectangle
//{
//    public override int Width
//    {
//        get { return base.Width; }
//        set
//        {
//            base.Height = value;
//            base.Width = value;
//        }
//    }
//    public override int Height
//    {
//        get { return base.Height; }
//        set
//        {
//            base.Height = value;
//            base.Width = value;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Rectangle rect = new Square();
//            rect.Width = 5;
//            rect.Height = 10;

//            Console.WriteLine(rect.GetRectangleArea());
//            //Відповідь 100? Що не так???
//            Console.ReadKey();
//        }
//    }
//}