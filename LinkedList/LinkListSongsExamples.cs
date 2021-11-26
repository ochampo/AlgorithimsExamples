using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkListSongsExamples
    {

        public void LinkListSongsExamplesTest1()
        {

            String[] songs = { "shout",
            "satisfation", "help",
            "stairway to heavan",
            "come sail away",
            "all night night long" };

            LinkedList<string> list = new LinkedList<string>(songs);

            list.AddLast("Thugz");
            

        }

    }
}
