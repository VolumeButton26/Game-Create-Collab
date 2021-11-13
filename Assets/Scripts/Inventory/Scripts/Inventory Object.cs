using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory {

    public class InventoryObject : ScriptableObject {
        public List<ItemBase> Items = new();
    }

}