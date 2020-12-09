using System;

namespace Polimorfizm
{
    class Program
    {
        static void printAreaAndPerivetr(Figure f)
        {
            Console.WriteLine($"Perimetr {f.P()}");
            Console.WriteLine($"Area {f.S()}");
        }
        static void printCollectionFigure(Figure[] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine($"Perinetr {f[i].P()}");
                Console.WriteLine($"Perinetr {f[i].S()}");
            }
        }
        static void Main(string[] args)
        {
            Figure[] figures1 = { new Square(2), new Rectangle(2, 4), new Triangle(2, 4, 3) };
            printAreaAndPerivetr(figures1[2]);
            Console.WriteLine();
            printCollectionFigure(figures1);

            Figure[] figures = { new Square(2), new Rectangle(2, 4), new Triangle(2, 4, 6) };//т.к. в треугольнике значения заданы некорректно, то вылетит Exeption

            printAreaAndPerivetr(figures[0]);
            Console.ReadKey();
        }
    }
}
