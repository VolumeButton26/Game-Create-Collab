using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory {

    public abstract class ItemBase : ScriptableObject {
        public GameObject Prefab;

        /// <summary>
        /// The item's type.
        /// </summary>
        public ItemType ItemType;


        /// <summary>
        /// Number of max stacks on the item.
        /// 1 means unstackable.
        /// </summary>
        public long MaxStacks = long.MaxValue;


        [TextArea(1, 2)]
        public string ItemName;

        /// <summary>
        /// Summary of the description.
        /// If empty, then Description will also be summary.
        /// </summary>
        [TextArea(1, 5)]
        public string Summary = string.Empty;

        /// <summary>
        /// What the item does.
        /// </summary>
        [TextArea(2, 10)]
        public string Description;
    }
}