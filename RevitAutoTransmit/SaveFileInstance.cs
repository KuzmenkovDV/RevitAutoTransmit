using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAutoTransmit
{
    /// <summary>
    /// Класс, в котором хранится информация об одной группе файлов для выгрузки
    /// </summary>
    [Serializable]
    
    internal class SaveFileInstance
    {
        internal string Name { get; set; }
        internal string Path { get; set; }
        internal List<RevitFileInstance> Instances { get; set; }
        internal SaveFileInstance(string name, string path, List<RevitFileInstance> instances) 
        {
            Name = name;
            Path = path;
            Instances = instances;
        }
    }
}
