using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.UIManagement
{
    /**
     * Interface Screen defines the public data members and
     * class references for each screen object.
     **/
    interface Screen
    {
        // Public class references
        StateManager m_manager { get; set; }

        // Public data members
        bool m_initialized { get; set; }
        bool m_loaded { get; set; }
        List<int> m_stateIDs { get; set; }
        int m_screenResolutionX { get; set; }
        int m_screenResolutionY { get; set; }

        /**
         * void initialize will be called to initialize this screen object.
         **/
        void initialize();

        /**
         * void Load will load this screen object to the stage
         **/
        void Load();

        /**
         * Update is called every frame to update the state of the stage.
         **/
        void Update(float delta);
    }
}
