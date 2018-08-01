using System;
using System.Collections.Generic;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFlyweightFactory sf = new ShapeFlyweightFactory();

            // Total 20 shapes objects drawn, but only two created
            for(int i = 0; i < 10; i++) {
                sf.getShape("rect").draw();
                sf.getShape("circle").draw();
            }

            Console.WriteLine("Total objects created: {0} ", sf.getTotalShapesCreated() );            
        }
    }
}
