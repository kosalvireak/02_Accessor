using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02_Example_Accessor_
{
    class House
    {
        public string strType;          //property
        private string strAddress;
        public string Address   //Address is the read & write accessor //It is an property
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        private float fltPrice;
        public float Price              //property
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
