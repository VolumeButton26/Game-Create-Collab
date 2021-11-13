using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory {
    [CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Items/Inventory")]
    public class InventoryObject : ScriptableObject {
        public List<ItemBase> Items = new List<ItemBase>();
    }
}