using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManagement
{
    /**
      * class ArenaState implements the the main gameplay state. 
      * It will display a screen object called "GamePlayScreen" and
      * update frames as needed. When inputs are triggered to change the state of
      * the StageManager this screen will stop being displayed.
      **/
    class ArenaState : State
    {

        // Reference to the state manager.
        public StateManager m_stateManager { get; set; }
        // Id of this state.
        public int m_stateID { get; set; }
        // Bool to check whether this state has finished loading.
        public bool m_stateLoaded { get; set; }
        // List of screen ids.
        public List<int> m_screenIds { get; set; }
        // Current screen that is displayed.
        public Screen m_currentScreen { get; set; }

        /**
         * Initialize will initialize this state with its respective screen and game objects.
         **/
        public void Initialize()
        {

        }

        /**
         * Load will load this state and its screen.
         **/
        public void Load()
        {

        }

        /**
         * Update is called every frame to update the position of game objects
         * in the frame.
         **/
        public void Update(float delta)
        {

        }

        /**
         * Get Screen returns the screen at the specified index. Since this
         * is not the StateManager this method will not be needed.
         */
        public Screen GetScreen(int index)
        {
            return null;
        }
    }
}
