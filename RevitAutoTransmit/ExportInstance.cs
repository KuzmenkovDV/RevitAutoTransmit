using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAutoTransmit
{
    [Serializable]
    internal class ExportInstance
    {
        internal string Name { get; set; }
        internal string CopyFrom { get; set; }
        internal string CopyTo { get; set; }
        internal ObservableCollection<RevitFileInstance> Files { get; set; }
        internal ExportInstance(string name, string copyFrom, string copyTo, ObservableCollection<RevitFileInstance> files)
        {
            Name = name;
            CopyFrom = copyFrom;
            CopyTo = copyTo;
            Files = files;
        }


    }
}
