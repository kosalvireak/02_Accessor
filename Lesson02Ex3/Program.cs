using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Ex3
{
    class Circle
    {
        private float fltRadius;
        public float Radius
        {
            get { return fltRadius; }
            set { if (value > 0)fltRadius = value; }
        }
        private string strColor;
        public string Color
        {
            get { return strColor; }
            set { strColor = value; }
        }

    internal class Program
    {
        static void Main(string[] args)
        {
                Circle cObj; //declare an object name of type Circle 
                cObj = new Circle(); // instantiate an object && assign it to the object name cObj
                Console.Write("Enter the radius: ");
                cObj.Radius = float.Parse(Console.ReadLine());

                Console.Write("Enter the color: ");
                cObj.Color = (Console.ReadLine());

                Console.WriteLine("The radius: {0}, The color: {1} ",cObj.Radius,cObj.Color);

        }
    }
    }
}
