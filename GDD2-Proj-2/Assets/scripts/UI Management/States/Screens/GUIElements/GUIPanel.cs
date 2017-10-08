using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.UIManagement
{
    /**
     * class GUIPanel will be used to store interactable UI elements
     * such as the list of options.
     **/
    class GUIPanel
    {
        // Public data fields
        public Vector2 m_position { get; set; }
        public int m_depth { get; set; }
        public bool m_visible { get; set; }
        public bool m_enabled { get; set; }

        // Private data fields
        private List<GUIElement> m_elements;
    }
}
