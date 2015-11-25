using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeirdChess.Interfaces
{
    public interface ISerializer<in T> where T : ISavable
    {
        void Serialise(T settings);
    }
}
