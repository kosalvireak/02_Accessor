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
            House hObj = new House();
            Console.Write("Enter the type of House");
            hObj.strType = Console.ReadLine();

            Console.Write("Enter the address of House");
            hObj.Address = Console.ReadLine(); // The value we typed will go to private variable
                                               // As in line 16 set { strAddress = value; } we set that value to strAddress

            Console.Write("Enter the price");
            hObj.Price = float.Parse(Console.ReadLine());

            Console.WriteLine("Type = {0}, Address = {1}, Price = {2}",
                hObj.strType,hObj.Address,hObj.Price); // When we call hObj.Address, It will go to line 15 get { return strAddress; }
                                                       // it will get value from strAddress 
                                                       // Overall public string Address doesn't store anything,
                                                       // they just use to give and get value from private string strAddress
        }
    }
}
