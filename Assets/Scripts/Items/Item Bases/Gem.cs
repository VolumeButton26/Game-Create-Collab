using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Inventory {

    /// <summary>
    /// Base class of gem item type.
    /// </summary>
    [CreateAssetMenu(fileName = "New Gem Item", menuName = "Inventory System/Items/Gem")]
    public class Gem : ItemBase {
        public void Awake() {
            ItemType = ItemType.Gem;
            // can we stack this
        }
    }
}
