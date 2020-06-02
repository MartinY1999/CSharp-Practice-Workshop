namespace PointInRectangle
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Point CreatePoint(int[] coordinates)
        {
            return new Point(coordinates[0], coordinates[1]);
        }
    }
}
