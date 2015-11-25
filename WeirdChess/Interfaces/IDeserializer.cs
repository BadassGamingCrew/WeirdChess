using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WeirdChess.Interfaces
{
    public interface IDeserializer<out T> where T : ISavable
    {
        string FilePath { get; }
        T Deserialize();
    }
}
