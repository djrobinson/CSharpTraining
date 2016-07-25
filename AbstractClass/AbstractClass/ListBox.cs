using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class ListBox : Control
    {
        private List<string> list = new List<string>();

        public ListBox(
            int xPos,
            int yPos,
            List<string> contents) :
                base(xPos, yPos)
        {
            this.list = contents;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing from Listbox");
        }
    }
}
