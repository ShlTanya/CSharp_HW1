using System;
using System.Collections;
using System.Collections.Generic;

namespace HW2.UserCollection
{
    public class GenericsList<T>: IEnumerable, ICloneable
    {
        private List<T> _List = new List<T>();

        public object Clone()
        {
            GenericsList<T> newGList = new GenericsList<T>();
            for (int i = 0; i < _List.Count; i++)
                    newGList.Add(_List[i]);
            return newGList;
        }

        public int Count
        { get
          { return _List.Count; }      
        }
        
        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator<T>(_List);
        }

        public void Add(object Element)
        {
            if (!(Element is T))
                throw new ArgumentException($"Тип добавляемого элемента должен быть {typeof(T).ToString()}");
        
            _List.Add((T)Element);

        }
        
        public void Remove(int Index)
        {
            if (_List.Count <= 5)
                throw new Exception("Невозможно удалить элемент из коллекции, содержащей пять или менее элементов");

            _List.RemoveAt(Index);
        }
    }

    class MyListEnumerator<T>: IEnumerator
    {
        private List<T> _MyList;
        private int _CurrPos = -1;

        public object Current
        { get
            {
                return _MyList[_CurrPos];
            }
        }

        public MyListEnumerator(List<T> MyList)
        {
            _MyList = MyList;
        }

        public bool MoveNext()
        {
            if(_CurrPos < _MyList.Count - 1)
            {
                _CurrPos++;
                return true;
            }
            return false;
        }
          
        public void Reset()
        {
            _CurrPos = -1;
        }
    }
}
