using System;

namespace shapes
{
    public interface IShape
    {
        void draw();
    }

    public class Rectangle : IShape
    {
        public void draw(){
            Console.WriteLine("Drawing Rectangle");
        }
    }

    public class Circle : IShape
    {
        public void draw(){
            Console.WriteLine("Drawing Circle");
        }
    }
}