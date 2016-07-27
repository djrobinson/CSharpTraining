using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class ConcreteRegularPolygon
    {
        //This is considered a backing field. Has the 
        private int _numberOfSides;

        public int NumberOfSides
        {
            get { return _numberOfSides; }
            set { _numberOfSides = value; }
        }

        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

    }
}
