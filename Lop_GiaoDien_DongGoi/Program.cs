using System;

namespace Lop_GiaoDien_DongGoi
{
    public abstract class Shape
    {
        private float _area;
        private System.Drawing.Color _color;
        private float _perimeter;
        public float Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public System.Drawing.Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public float Perimeter
        {
            get
            {
                return _perimeter;
            }
            set
            {
                _perimeter = value;
            }
        }
        //Khai báo các method trừu tượng
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }

    class Rectangle : Shape
    {
        private float _height;
        private float _width;
        public Rectangle(float height, float width)
        {
            _height = height;
            _width = width;
        }
        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public override void CalculateArea()
        {
            this.Area = _height * _width;
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = (_height * 2) + (_width * 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
