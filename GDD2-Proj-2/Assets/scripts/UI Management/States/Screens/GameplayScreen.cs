using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.UIManagement
{
    /**
     * class GameplayScreen is the screen that is displayed while the game
     * is being played. This is where the mages and stage are displayed
     * and objects are updated based on user inputs.
     **/
    class GameplayScreen : Screen
    {
        // Public class references
        public StateManager m_manager { get; set; }

        // Public data members
        public bool m_initialized { get; set; }
        public bool m_loaded { get; set; }
        public List<int> m_stateIDs { get; set; }
        public int m_screenResolutionX { get; set; }
        public int m_screenResolutionY { get; set; }

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
