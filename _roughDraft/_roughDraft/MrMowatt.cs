using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _roughDraft
{
    //--Interface--//
    interface IKnowledge
    {
        string educationBank();
    }

    //--Mr. Mowatt class
    class MrMowatt : IKnowledge
    {
        private bool _Comprendre;   //--Frend word for understand/comprehend

        string IKnowledge.educationBank()
        {
            return "";
        }
    }
}
