using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[4];
            shapes[0] = new Shapes();
            shapes[1] = new Circle();
            shapes[2] = new Lines();
            shapes[3] = new triangle();

            foreach (var shape in shapes)
            {
                shape.Draw();
                  
            }
        }
    }

    class Shapes
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a simple shapes");
        }
    }

    class Lines:Shapes
    {
        public new void Draw()
        {
            Console.WriteLine("I am a Line");
        }
    }

    class Circle:Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am a  circle");
        }
    }
    class triangle:Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am a triangle");
        }
    }
}
