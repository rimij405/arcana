﻿/************************************************
 * GUIElement.cs
 * 
 * Contains implementation for the GUIElement interface.
 ************************************************/

/////////////////////
// Using statements.
/////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game.UI.Elements
{
    /// <summary>
    /// Interface of the GUI objects that screens will be creating during gameplay.
    /// </summary>
    interface GUIElement
    {

        #region Data Members
        
        /// <summary>
        /// Position of the GUIElement.
        /// </summary>
        Vector2 m_position { get; set; }

        /// <summary>
        /// Depth level.
        /// </summary>
        int m_depth { get; set; }

        /// <summary>
        /// Element visibility.
        /// </summary>
        bool m_visible { get; set; }

        /// <summary>
        /// Enable flag.
        /// </summary>
        bool m_enabled { get; set; }
        
        #endregion

    }
}
