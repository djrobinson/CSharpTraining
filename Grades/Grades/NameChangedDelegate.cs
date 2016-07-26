using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    //below is the common convention for creating an event
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
}
