using System.Collections;

namespace Section1._3
{
    internal class LinkedListStack<T> : IEnumerable<T>
    {

        private class Node<T>
        {
            public T Item { get; set; }
            public Node<T> next { get; set; }
        }


        private Node<T> _firstNode;
        public int Count { get; set; }

        public LinkedListStack(T FirstItem)
        {
            _firstNode = new Node<T> { Item = FirstItem, next = null };
            Count = 1;
        }

        public void Push(T item)
        {
            Node<T> OldFirst = _firstNode;
            _firstNode = new Node<T> { Item = item, next = OldFirst };
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("There is no more item to pop");
            }
            T Item = _firstNode.Item;
            _firstNode = _firstNode.next;
            Count--;
            return Item;

        }

        public bool IsEmpty()
        {
            return Count == 0;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new LLSEnumerator(_firstNode);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LLSEnumerator : IEnumerator<T>
        {

            private Node<T> _currentNode;
            private Node<T> _nextNode;


            public LLSEnumerator(Node<T> firstNode)
            {
                _nextNode = firstNode;
            }

            public bool MoveNext()
            {
                if (_nextNode == null)
                {
                    return false;
                }
                else
                {
                    _currentNode = _nextNode;
                    _nextNode = _nextNode.next;

                    return true;
                }
            }

            public void Reset()
            {
                throw new NotSupportedException("Reset is not supported");
            }

            public T Current => _currentNode.Item;

            object IEnumerator.Current => _currentNode.Item;

            public void Dispose() { }


        }

    }
}
