﻿/************************************************
 * GUIButton.cs
 * 
 * Contains implementation for GUIButton.
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
    /// Button that can be interacted with by players.
    /// </summary>
    public class GUIButton : GUIElement
    {

        #region Data Members

        /////////////////////
        // Public data fields.
        /////////////////////

        /// <summary>
        /// Position of the GUIElement.
        /// </summary>
        public Vector2 m_position { get; set; }

        /// <summary>
        /// Depth level.
        /// </summary>
        public int m_depth { get; set; }

        /// <summary>
        /// Element visibility.
        /// </summary>
        public bool m_visible { get; set; }

        /// <summary>
        /// Enable flag.
        /// </summary>
        public bool m_enabled { get; set; }

        /////////////////////
        // Private data fields.
        /////////////////////

        /// <summary>
        /// Children that may be GUI elements.
        /// </summary>
        private List<GUIElement> m_elements;

        #endregion

    }
}
