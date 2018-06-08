using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public abstract class Item : IComparable
    {
        private Guid _id;
        
        public abstract string Name { get; }
        public abstract double Weight { get; }
        public abstract InventorySlotId Slot { get; }
        public abstract bool IsNatural { get; }
        public System.Guid Id { get { return _id; } }

        public Item()
        {
            _id = Guid.NewGuid();
        }

        public int CompareTo(object obj)
        {
            Item items = (Item)obj;
            return this.Id.CompareTo(items.Id);
        }

        public override bool Equals(object obj)
        {
            //Checks to see if the weight of two Items are equal
            if (obj == null) { return false; }
            if (object.ReferenceEquals(this, obj)) { return true; }
            if (this.GetType() != obj.GetType()) { return false; }

            var other = (Item)obj;
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            //Returns the hash code of the id of an item
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            //Returns the info of an item
            return string.Format("Item: " + Name.ToString());
        }
    }
}
