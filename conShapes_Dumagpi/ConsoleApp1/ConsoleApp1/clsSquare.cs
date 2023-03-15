using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class clsSquare: clsShape
    {
        private string sqname;
        private int sqsides;
        private double sqside1;

        public clsSquare(string sqname, int sqsides, double sqside1)
        {
            this.sqname = sqname;
            this.sqsides = sqsides;
            this.sqside1 = sqside1;
        }

        public clsSquare()
        { 
        }
        public string SqName { get => sqname; set => sqname = value; }
        public int SqSides { get => sqsides; set => sqsides = value; }
        public double Side1 { get => sqside1; set => sqside1 = value; }



        public override string ToString()
        {
            return "\nName: " + this.sqname +
                    "\nSides: " + this.sqsides +
                    "\nLength of a side: " + this.sqside1 +
                    "\nArea: " + this.ComputeArea() +
                    "\nPerimeter: " + this.ComputePerimeter();


        }

        public override double ComputeArea()
        {
            return Math.Pow(this.Side1,2);
        }

        public override double ComputePerimeter()
        {
            return this.Side1*4;
        }

    }
}
