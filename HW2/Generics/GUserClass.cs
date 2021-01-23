using System;
using System.Collections.Generic;
using HW2.UserCollection;

namespace HW2.Generics
{
    class GenericsUserClass<T, R> 
        where T: struct 
        where R: GenericsList<T>
    {
        public T Element{ get; set; }
        private R _GList;

        public GenericsUserClass(R gList)
        {
            _GList = gList;
        }

        public R AddElement()
        {
            _GList.Add(Element);
            return _GList;
        }
    }

    class GenericsUserClassR<T, R>
        where T : struct
        where R : GenericsList<T>, new()
    {
        public T Element { get; set; }
        private R _GList = new R();

        public GenericsUserClassR(R gList)
        {
            _GList = (R)gList.Clone();
        }

        public R AddElement()
        {
            _GList.Add(Element);
            return _GList;
        }
    }
}
