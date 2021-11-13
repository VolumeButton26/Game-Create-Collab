using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory {

    /// <summary>
    /// Debug Object!
    /// </summary>
    [CreateAssetMenu(fileName = "New Placeholder Item", menuName = "Inventory System/Items/Default")]
    public class PlaceholderObject : ItemBase {
        public void Awake() {
            ItemType = ItemType.Placeholder;
        }
    }
}