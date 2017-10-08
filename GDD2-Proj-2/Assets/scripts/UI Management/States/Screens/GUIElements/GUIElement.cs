using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.UIManagement
{
    /**
     * Interface GUIElement outlines the GUI objects that
     * screens will be creating during gameplay.
     **/
    interface GUIElement
    {
        // Public data fields
        Vector2 m_position { get; set; }
        int m_depth { get; set; }
        bool m_visible { get; set; }
        bool m_enabled { get; set; }
    }
}
