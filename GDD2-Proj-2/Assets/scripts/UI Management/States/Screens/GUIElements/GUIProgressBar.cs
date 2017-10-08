using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.UIManagement
{
    /**
     * class GUIProgressBar is the loading bar that is
     * displayed in the loading screen.
     **/
    class GUIProgressBar
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
