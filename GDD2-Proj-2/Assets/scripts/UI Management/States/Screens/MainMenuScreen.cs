using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManagement
{
    /**
     * class HomeScreen is the screen that is displayed after the splash screen.
     * It will have a list of places to navigate to. For now the list will be
     * "Play", "Options", "Exit".
     **/
    class HomeScreen : Screen
    {
        // Public class references
        public StateManager m_manager { get; set; }

        // Public data members
        public bool m_initialized { get; set; }
        public bool m_loaded { get; set; }
        public List<int> m_stateIDs { get; set; }
        public int m_screenResolutionX { get; set; }
        public int m_screenResolutionY { get; set; }

        // Private Data Members
        private Vector2 m_position;
        private Vector2 m_dimensions;
        private float m_timeToLive;
        private GameObject m_resource;

        /**
         * void initialize will be called to initialize this screen object.
         **/
        public void initialize()
        {

        }

        /**
         * void Load will load this screen object to the stage
         **/
        public void Load()
        {

        }

        /**
         * Update is called every frame to update the state of the stage.
         **/
        public void Update(float delta)
        {

        }
    }
}
