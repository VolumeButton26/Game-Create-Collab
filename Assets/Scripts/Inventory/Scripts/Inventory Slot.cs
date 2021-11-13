using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory {
    [System.Serializable]
    public class InventorySlot {
        /// <summary>
        /// We can only have one type of item per inventory.
        /// </summary>
        public ItemBase Item;

        public long Amount;

        /// <summary>
        /// Fill a new instance of inventory slot!
        /// </summary>
        /// <param name="item">Item in the inventory.</param>
        /// <param name="amount">Number of items in the inventory not exceeding 65,535.</param>
        public InventorySlot(ItemBase item, long amount) {
            Item = item; 
            Amount = amount;
        }

        /// <summary>
        /// Appends the amount ONCE.
        /// </summary>
        /// <returns>The the amount of items that overflows the stack, should be 1 if there is.</returns>
        public long AppendAmount() {
            if (Amount < Item.MaxStacks) {
                Amount++;
                return 0;
            } else return 1;
        }

        /// <summary>
        /// Appends the specified amount of objects to the slot.
        /// </summary>
        /// <returns>The amount of items that can't be stacked, should be added to next inventory. 0 if none.</returns>
        public long AppendAmount(long amount) {

            if (Amount + amount > Item.MaxStacks) {  // make sure to not overflow the long
                long addedItems = Item.MaxStacks - Amount;
                Amount = Item.MaxStacks; // set to max value if too many
                return amount - addedItems;
            }

            Amount += amount;
            return 0;
        }

    }
}
