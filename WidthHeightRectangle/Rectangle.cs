namespace WidthHeightRectangle
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2.0 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Height * Height) + (Width * Width));            
        }
    }
}
