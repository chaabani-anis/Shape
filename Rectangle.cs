namespace Shape
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int CalculateArea()
        {
                return Height * Width;
        }
    }
}