using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal abstract class IDBInteract
    {
        public abstract bool Insert();
        public abstract bool Update();
        public abstract bool Delete();
        public abstract List<string>[] Select();
        public abstract int Count();
        
    }
}
