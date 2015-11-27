using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeirdChess.Interfaces;

namespace WeirdChess.Utilities
{
    public class Iterator<T> : IIterator<T>
    {
        private ICollection<T> collection; 

        public Iterator(ICollection<T> collection)
        {
            this.collection = collection;
        }

        public void First()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Previous()
        {
            throw new NotImplementedException();
        }

        public void Last()
        {
            throw new NotImplementedException();
        }

        public T Current()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }
    }
}
