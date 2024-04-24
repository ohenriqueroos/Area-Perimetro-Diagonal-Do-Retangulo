﻿using System.Globalization;

namespace WidthHeightRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Informe a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}