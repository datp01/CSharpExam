using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        public static void Main()
        {
            double Radius, Height, BaseArea, LateralArea, TotalArea, Volumn;
            Console.WriteLine("Enter the dimenstions of the cylinder : ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Height = Convert.ToDouble(Console.ReadLine());
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volumn = Math.PI * Radius * Height * Radius;
            Console.WriteLine("Radius: {0},Height:{1}", Radius, Height);
            Console.WriteLine("Base: {0}; Lateral:{1}; Total:{2}; Volume:{3}",BaseArea, LateralArea, TotalArea,Volumn);
        }
    }
          
}
