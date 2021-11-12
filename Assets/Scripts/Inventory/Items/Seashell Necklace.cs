using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Items {

    // this is one item right? not sure if this is a type of item maybe we should interface this too
    public class SeashellNecklace : IItem {

        private string _name = "Seashell Necklace";

        private string _description = "This thing does...things.";

        public string ItemName {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }

        public string ItemDescription {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
    }
}
