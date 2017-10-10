/************************************************
 * IState.cs
 * 
 * This file contains implementation for the State interface.
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

    /// <summary>
    /// An interface describing the fields and methods that will be implemented by each of the State classes.
    /// </summary>
    public interface IState
    {

        #region Data Members

        /// <summary>
        /// Reference to the state manager.
        /// </summary>
        StateManager m_stateManager { get; set; }

        /// <summary>
        /// This State's ID.
        /// </summary>
        StateID m_stateID { get; set; }

        /// <summary>
        /// Flag checks if this state has finished loading.
        /// </summary>
        bool m_stateLoaded { get; set; }

        /// <summary>
        /// Ordered list of Screen ID's used for this state.
        /// </summary>
        List<ScreenID> m_screenIds { get; set; }

        /// <summary>
        /// Reference to the current screen.
        /// </summary>
        IScreen m_currentScreen { get; set; }

        #endregion

        #region Service Methods

        /// <summary>
        /// Initialize the LoadingState with its respective screen and game objects.
        /// </summary>    
        void Initialize();

        /// <summary>
        /// Load the LoadingState and its Screen.
        /// </summary>
        void Load();

        /// <summary>
        /// Update LoadingState dependencies.
        /// </summary>
        /// <param name="delta">Elapsed time since last frame (in seconds).</param>
        void Update(float delta);

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
        IScreen GetScreen(ScreenID id);

        #endregion

    }
}
