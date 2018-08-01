using System;
using System.Collections.Generic;

namespace shapes
{
    public class ShapeFlyweightFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int getTotalShapesCreated(){
            return shapes.Count;
        }

        public IShape getShape(string type) {
            IShape shape = null;
            if(shapes.ContainsKey(type)) {
                shape = shapes[type];
            } else {
                switch (type) {
                    case "rect" :
                        shape = new Rectangle();
                        shapes.Add("rect",  shape);
                        return shape; 
                    case "circle" :
                        shape = new Circle();
                        shapes.Add("circle", shape);
                        return shape;
                    default: 
                        throw new Exception("Factory cannot create specified object");
                }
            }
            return shape;
        }
    }
}
