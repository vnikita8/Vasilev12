using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev12
{
    public enum Visible { Видимый, Невидимый}
    internal abstract class Figure
    {
        public string Color;
        public Visible visible;
        public double X;
        public double Y;

        public void MoveY(int move) { Y += move; }
        public void MoveX(int move) { X += move; }
        public void ChangeColor(string newColor) { Color = newColor; }
        public void ChangeVisible(Visible newVisible) { visible = newVisible; }
        public Visible GetVisible() { return visible; } 
        public string GetInfo() { return $"X: {X}, Y: {Y}, Color: {Color}, Visible: {visible}"; }
    }

    internal class Point : Figure {}

    internal class Circle : Point 
    {
        public void Area() { }
    }

    internal class Rectangle : Point
    {
        public void Area()
        {

        }
    }

}
