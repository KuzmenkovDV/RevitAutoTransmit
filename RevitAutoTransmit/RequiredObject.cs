using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAutoTransmit
{
    [Serializable]
    internal class RequiredObject
    {
        internal string Name { get; set; }
        internal string Type { get; set; }
        internal string SubFolderPath { get; set; }
        internal bool IsRevitFile { get; set; }
        internal bool NeedToCopy { get; set; }
        internal bool AddDateInFront { get; set; }
        internal RequiredObject(string name, string type, string subFolderPath, bool isRevitFile, bool needToCopy, bool addDateInFront)
        {
            Name = name;
            Type = type;
            SubFolderPath = subFolderPath;
            IsRevitFile = isRevitFile;
            NeedToCopy = needToCopy;
            AddDateInFront = addDateInFront;
        }

    }
}
