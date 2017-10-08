using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.UIManagement
{
    /**
     * class PauseScreen is the screen that is displayed when a player presses the pause
     * button. Effectively this screen should be a transparent overlay that goes over the
     * GameplayScreen and gives the players the option to end the game or go to the options
     * menu. We can also include the controls on this screen.
     **/
    class PauseScreen: Screen
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
