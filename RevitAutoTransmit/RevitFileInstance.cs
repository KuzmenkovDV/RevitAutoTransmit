using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAutoTransmit
{
    [Serializable]
    internal class RevitFileInstance
    {
        internal string Name { get; set; }
        internal string PathToRead { get; set; }
        internal string PathToWrite { get; set; }
        internal bool NeedToCopy { get; set; }
        internal bool AddDateInFront { get; set; }
        internal RevitFileInstance(string name, string pathToRead, string pathToWrite, bool needToCopy, bool addDateInFront )
        {
            Name = name;
            PathToRead = pathToRead;
            PathToWrite = pathToWrite;
            NeedToCopy = needToCopy;
            AddDateInFront = addDateInFront;
        }
           
        

    }
}
