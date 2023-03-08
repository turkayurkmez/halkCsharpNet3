﻿namespace GenericTypes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }
    }

    public class DoublePoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void Reset()
        {
            X = 0.0;
            Y = 0.0;
        }
    }

    public class ObjectPoint
    {
        public object X { get; set; }
        public object Y { get; set; }

        public void Reset()
        {
            X = 0.0;
            Y = 0.0;
        }
    }

    public class GenericPoint<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }
    }




}
