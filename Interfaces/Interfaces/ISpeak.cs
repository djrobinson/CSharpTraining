using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ISpeak
    {
        double DurationOfSpeech { get; }
        void Speak();
    }
}
