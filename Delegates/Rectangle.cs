using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void RectDelegate(double Width, double Height);
    internal class Rectangle
    {
        public void GetArea(double Width, double Height)
        { 
            Console.WriteLine("Area of rectangle"+ Width * Height);
        
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of rectangle" + 2 * (Width + Height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj += rect.GetPerimeter;
            obj.Invoke(12.00, 15.00);

            Console.WriteLine();

            obj.Invoke(47.87, 37.89);
            Console.ReadLine();

        }
    }
}
