using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory {
    public class InventorySlot {
        public ItemBase Item;

        public byte Amount;

        /// <summary>
        /// Fill a new instance of inventory slot!
        /// </summary>
        /// <param name="item">Item in the inventory.</param>
        /// <param name="amount">Number of items in the inventory not exceeding 65,535.</param>
        public InventorySlot(ItemBase item, byte amount) {
            Item = item; 
            Amount = amount;
        }

        /// <summary>
        /// Appends the ammount ONCE.
        /// </summary>
        /// <returns>True if successful, then the amount of items that overflows the stack.</returns>
        public byte AppendAmount() {
            if (Amount < Item.MaxStacks) {
                Amount++;
                return 0;
            } else return 1;
        }

        public byte AppendAmount(byte amount) {

            if (Amount + amount > Item.MaxStacks) {  // make sure to not overflow the byte
                Amount = Item.MaxStacks; // set to max value if too many
                return (byte)((int)Item.MaxStacks - (int)amount) /* why microsoft why */;
            }

            Amount += amount;
            return 0;
        }

    }
}
