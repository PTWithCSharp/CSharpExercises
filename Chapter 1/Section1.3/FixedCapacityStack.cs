using System.Collections;

namespace Section1._3
{
    public class FixedCapacityStack<T> : IEnumerable<T>
    {
        private T[] _elements = new T[1];
        private int _N;


        public FixedCapacityStack()
        {
            _N = 0;

        }

        private void Resize(int size)
        {
            T[] newElements = new T[size];

            for (int i = 0; i < _N; i++)
            {
                newElements[i] = _elements[i];
            }
            _elements = newElements;
        }

        public void Push(T item)
        {
            if (_N == _elements.Length)
            {
                Resize(2 * _elements.Length);
            }
            _elements[_N++] = item;

        }

        public T Pop()
        {
            T item = _elements[--_N];
            _elements[_N] = default;

            if (_N >= 0 && _N < _elements.Length / 4)
            {
                Resize(_N / 2);
            }

            return item;
        }

        public bool isEmpty()
        {
            return _N == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _elements.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}