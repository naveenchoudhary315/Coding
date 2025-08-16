namespace DataType.ValueType
{
    public class EnumsStructure
    {
        public enum EnumeTest
        {  
           a=0,
           b=1,c=2,d=3,e=4,
        }
        public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }
    }
}
