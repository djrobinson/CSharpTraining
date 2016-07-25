using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Control
    {
        protected int xPos;
        protected int yPos;

        public Control(
            int xPosition,
            int yPosition)
        {
            xPos = xPosition;
            yPos = yPosition;
        }

        public virtual void Clear()
        {
            Console.WriteLine("Clearing Control");
        }

        //This is what makes the class abstract. Implies that implementing classes must
        //define their own method "Draw" overriding this one.
        public abstract void Draw();
    }
}
