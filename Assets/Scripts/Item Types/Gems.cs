using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Inventory {

    [CreateAssetMenu(fileName = "New Gem Item", menuName = "Inventory System/Items/Gem")]
    public class Gems : ItemBase {
        public void Awake() {
            ItemType = ItemType.Gem;
        }
    }
}
