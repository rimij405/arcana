using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManagement
{
    /**
      * class StateManager implements the management of states of the game.
      * It will display the states that should be displayed based on inputs
      * from users and triggers from the game.
      **/
    class StateManager : State
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

        private List<State> states = new List<State>();

        /**
          * Initialize will initialize the state manager and its references to the State Objects.
          **/
        public void Initialize()
        {

        }

        /**
         * Load will load the current state and its screen.
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
         * Get Screen returns the screen at the specified index.
         */
        public Screen GetScreen(int index)
        {
            if(states[index] != null)
            {
                return states[index].m_currentScreen;
            } else {
                throw new ArgumentOutOfRangeException("Index was out of range of the list of screens");
            }
        }
    }
}
