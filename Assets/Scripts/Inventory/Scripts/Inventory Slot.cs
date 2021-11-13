using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory {
    public class InventorySlot {
        public ItemBase Item;

        // we won't have more than 65k items stacked right?
        private const byte maxStack = 64;
        public byte Amount;

        /// <summary>
        /// Fill a new instance of inventory slot!
        /// </summary>
        /// <param name="item">Item in the inventory.</param>
        /// <param name="amount">Number of items in the inventory not exceeding 65,535.</param>
        public InventorySlot(ItemBase item, byte amount) {
            Item = item; Amount = amount;
        }
        public void AppendAmount() {

        }
        public void AppendAmount(byte amount) {

            if (Amount + amount > maxStack) // make sure to not overflow the byte
                Amount = maxStack; // set to max value if too many

            Amount += amount;
        }
    }
}
