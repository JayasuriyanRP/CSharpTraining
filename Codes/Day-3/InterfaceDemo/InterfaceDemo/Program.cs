using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IArea
    {
        double CalculateArea();
    }
    class Circle:IArea
    {
        double _radius;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Radius { get => _radius; set => _radius = value; }
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
    class Triangle:IArea
    {
        double _tBase;
        double _tHeight;

        public Triangle()
        {

        }
        public Triangle(double tBase, double tHeight)
        {
            _tBase = tBase;
            _tHeight = tHeight;
        }
        public double TBase { get => _tBase; set => _tBase = value; }
        public double THeight { get => _tHeight; set => _tHeight = value; }

        public double CalculateArea()
        {
            return 0.5 * _tBase * _tHeight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
