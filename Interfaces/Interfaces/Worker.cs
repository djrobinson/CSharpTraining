using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Document doc1 = new Interfaces.Document();
            doc1.Reformat();
            doc1.Read("myfile");
            doc1.Speak();

            IStorable doc2 = new Document();
            doc2.Read("myfile");
            doc2.Write("myfile2");
            // can't call doc2.Speak, since it's IStorable

            ISpeak doc3 = new Document();
            doc3.Speak();
            //can't do doc3.Read();

            Document doc4 = new Memo();
            doc4.Reformat();
            doc4.Read("myfile");

            Memo doc5 = new Memo();
            doc5.Read("myfile");
            doc5.Reformat();
            doc5.Speak();
            doc5.Write("myfile");
        }
    }
}
