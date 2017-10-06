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
        
        public StateManager m_stateManager { get; set; }
        public int m_stateID { get; set; }
        public bool m_stateLoaded { get; set; }
        public List<int> m_screenIds { get; set; }
        public Screen m_currentScreen { get; set; }

        public void Initialize()
        {

        }
        public void Load()
        {

        }
        public void Update(float delta)
        {

        }

        public Screen GetScreen(int index)
        {
            return null;
        }
    }
}
