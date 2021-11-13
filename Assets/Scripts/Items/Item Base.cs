using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory {

    public abstract class ItemBase : ScriptableObject {
        public GameObject Prefab;
        public ItemType ItemType;

        /// <summary>
        /// Number of max stacks on the item.
        /// </summary>
        public byte MaxStacks = 64;


        [TextArea(1, 2)]
        public string ItemName;

        [TextArea(1, 5)]
        public string SmallDescription;
        [TextArea(2, 10)]
        public string LargeDescription;
    }
}