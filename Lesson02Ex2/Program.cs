﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Ex2
{
    class Phone
    {
        public string strModel;
        private float fltScreenSize;
        public float ScreenSize
        {
            get { return fltScreenSize; }
            set { if (value > 0) fltScreenSize = value; }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Phone pObj = new Phone();
                Console.Write("Enter the model: ");
                pObj.strModel=Console.ReadLine();

                Console.Write("Enter the Screen size:");
                pObj.ScreenSize = float.Parse(Console.ReadLine());

                Console.WriteLine("The model is: {0}, The screen size is: {1}",pObj.strModel, pObj.ScreenSize);
            }
        }
    }
}
