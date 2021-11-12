using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Inventory {

    // blueprint for all items
    public interface IItem {
        string ItemName { get; set; }
        string ItemDescription { get; set; }
    }
}