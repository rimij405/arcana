using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManager
{
    /**
     * Interface State describes the fields and methods that will be implimented by
     * Each of the State classes.
     **/ 
    interface State
    {
        StateManager m_stateManager { get; set; }
        int m_stateID { get; set; }
        bool m_stateLoaded { get; set; }
        List<int> m_screenIds { get; set; }
        Screen m_currentScreen { get; set; }

        void Initialize();
        void Load();
        void Update(float delta);
    }
}
