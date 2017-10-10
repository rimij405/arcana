/************************************************
 * GUILabel.cs
 * 
 * Contains implementation for GUILabel.
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
    /// GUIElement that displays text.
    /// </summary>
    class GUILabel
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
        private List<IGUIElements> m_elements;

        #endregion
    }
}
