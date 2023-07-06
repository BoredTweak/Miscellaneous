namespace csharp_9
{
    /// <summary>
    /// This class is used to demonstrate the new C# 9.0 feature of custom GetEnumerator support for foreach loops.
    /// </summary>
    internal class CustomEnumerator
    {
        private readonly int[] _items = new int[] { 1, 2, 3, 4, 5 };
        private int _index = 0;

        public CustomEnumerator()
        {
        }

        public CustomEnumerator(int[] items)
        {
            _items = items;
        }

        public CustomEnumerator(int[] items, int index)
        {
            _items = items;
            _index = index;
        }

        public CustomEnumerator GetEnumerator() => new CustomEnumerator(_items, _index);

        public bool MoveNext() => ++_index < _items.Length;

        public int Current => _items[_index];
    }
}