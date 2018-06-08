using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class StoredItems
    {
        private Item[] _items;
        private int _count;

        public int Count { get { return _count; } }
        public int Capacity { get{ return 20; } }  // FIXME: return _items.Length;

        public StoredItems(int size)
        {
            _items = new Item[size];
            _count = 0;
        }

        public Item GetItem(int index)
        {
            return _items[index];
        }

        public Item SetItem(int index, Item item)
        {
            // FIXME: See below
            //Item prevItem = _items[index];
            //_items[index] = item;
            //return prevItem;

            item = _items[index];
            return item;
        }

        public void AddItem(Item item)
        {
            if (_count < Capacity)
            {
                _items[_count] = item;
                ++_count;
            }
            else
            {
                throw new BagFullException();
            }
        }

        public void RemoveItem(Item item)
        {
            int found = -1;

            for (int i = 0; i < _count; i++)
            {
                if (_items[i] == item && item != null)
                {
                    found = i;
                    _items[i] = null;
                    --_count;
                    break;
                }

            }
            if (found >= 0)
            {
                // FIXME: loop is wrong, see below
                // for (int i = found; i < _count; i++)
                for (int i = 0; i < found; i++)
                {
                    _items[i] = _items[i + 1];
                }
            }
        }

        public double CalcTotalWeigth()
        {
            return 0;
        }
    }
}
