using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory {

    [CreateAssetMenu(fileName = "New Placeholder Object", menuName = "Inventory System/Items/Default")]
    public class PlaceholderObject : Inventory.ItemBase {
        public void Awake() {
            base.ItemType = Inventory.ItemType.Placeholder;
        }
    }
}