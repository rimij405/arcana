﻿/************************************************
 * GameoverState.cs
 * 
 * This file contains implementation for the State subclass: GameoverState.
 ************************************************/

/////////////////////
// Using statements.
/////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.UI.Screens;

namespace Game.States
{
    /////////////////////
    // Class declaration.
    /////////////////////

    /// <summary>
    /// <para>Implements the end of game state.</para>
    ///  It will display a screen object called "GameoverScreen" and update frames as needed. When inputs are triggered to change the state of the StageManager this screen will stop being displayed.
    /// </summary>
    public class GameoverState : State
    {
        #region Data Members

        /// <summary>
        /// Reference to the state manager.
        /// </summary>
        public StateManager m_stateManager { get; set; }

        /// <summary>
        /// This State's ID.
        /// </summary>
        public StateID m_stateID { get; set; }

        /// <summary>
        /// Flag checks if this state has finished loading.
        /// </summary>
        public bool m_stateLoaded { get; set; }

        /// <summary>
        /// Ordered list of Screen ID's used for this state.
        /// </summary>
        public List<ScreenID> m_screenIds { get; set; }

        /// <summary>
        /// Reference to the current screen.
        /// </summary>
        public Screen m_currentScreen { get; set; }

        #endregion

        #region Service Methods

        /// <summary>
        /// Initialize the GameoverState with its respective screen and game objects.
        /// </summary>    
        public void Initialize()
        {
            // TODO: Stub.
        }

        /// <summary>
        /// Load the GameoverState and its Screen.
        /// </summary>
        public void Load()
        {
            // TODO: Stub.
        }

        /// <summary>
        /// Update GameoverState dependencies.
        /// </summary>
        /// <param name="delta">Elapsed time since last frame (in seconds).</param>
        public void Update(float delta)
        {
            // TODO: Stub.
        }

        #endregion

        #region Mutator Methods

        // TODO: Stub.

        #endregion

        #region Accessor Methods

        /// <summary>
        /// Get Screen returns the screen at the specified index. Since this is not the StateManager this method will not be needed.
        /// </summary>
        /// <param name="id">Screen ID associated with desired Screen object.</param>
        /// <returns></returns>
        public Screen GetScreen(ScreenID id)
        {
            // TODO: Stub.
            return null;
        }

        #endregion
    }
}
