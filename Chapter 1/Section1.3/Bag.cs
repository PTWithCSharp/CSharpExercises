using System.Collections;

namespace Section1._3
{
    internal class Bag<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }
        }

        private Node _firstNode;

        public int Count { get; private set; }

        public void Add(T item)
        {
            Node oldFirst = _firstNode;
            _firstNode = new Node() { Item = item, Next = oldFirst };
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new BagEnumerator(_firstNode);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class BagEnumerator : IEnumerator<T>
        {
            private Node _nextNode;
            private Node _currentNode;

            public BagEnumerator(Node firstNode)
            {
                _nextNode = firstNode;
            }

            public bool MoveNext()
            {
                if (_nextNode == null) return false;
                _currentNode = _nextNode;
                _nextNode = _nextNode.Next;
                return true;
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
