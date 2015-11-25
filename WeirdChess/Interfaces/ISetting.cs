using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeirdChess.Interfaces
{
    public interface ISetting<T>
    {
        string Name { get; }
        T Value { get; set; }
    }
}
