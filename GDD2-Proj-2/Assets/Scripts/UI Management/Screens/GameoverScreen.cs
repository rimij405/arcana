/************************************************
 * GameoverScreen.cs
 * 
 * This file contains implementation for the GameoverScreen class.
 ************************************************/

/////////////////////
// Using statements.
/////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Game.Resources;

namespace Game.UI.Screens
{
    /**
     * class GameoverScreen is the screen that gets displayed on game end.
     * It will display score and options to bring the players back to the main menu
     * or to start a new game.
     **/


    class GameoverScreen : IScreen
    {

        #region Data Members

        /////////////////////
        // Public data fields.
        /////////////////////

        /// <summary>
        /// Determines if Screen is initialized.
        /// </summary>
        public bool m_initialized { get; set; }

        /// <summary>
        /// Determines if Screen's resources are loaded.
        /// </summary>
        public bool m_loaded { get; set; }

        /// <summary>
        /// Screen resolution (x-axis).
        /// </summary>
        public int m_screenResolutionX { get; set; }

        /// <summary>
        /// Screen resolution (y-axis).
        /// </summary>
        public int m_screenResolutionY { get; set; }


        /////////////////////
        // Private data fields.
        /////////////////////

        /// <summary>
        /// Position of the screen. (Global Coordinates).
        /// </summary>
        private Vector2 m_position;

        /// <summary>
        /// Dimensions of the screen in 2D world space.
        /// </summary>
        private Vector2 m_dimensions;
        
        /// <summary>
        /// Length of time the screen should be active for.
        /// </summary>
        private float m_timeToLive;
        
        /// <summary>
        /// Resource for the screen? // TODO: Stub.
        /// </summary>
        private Resource m_resource;

        #endregion

        #region Service Methods

        /// <summary>
        /// Initialize this Screen object.
        /// </summary>
        public void Initialize()
        {

            // TODO: Stub.

        }

        /// <summary>
        /// Load this Screen object's resources.
        /// </summary>
        public void Load()
        {

            // TODO: Stub.

        }

        /// <summary>
        /// Update the stage on every frame.
        /// </summary>
        public void Update(float delta)
        {

            // TODO: Stub.

        }

        #endregion

        #region Mutator Methods

        // TODO: Stub.

        #endregion

        #region Accessor Methods

        // TODO: Stub.

        #endregion

    }
}
