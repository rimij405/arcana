using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManagement
{
    /**
      * class LoadingState implements the state of the game when the game objects for
      * the next screen are loading. It will display a screen object called "LoadingScreen" and
      * update frames as needed. When Game Object finish loading
      * the StageManager will display the new screen.
      **/
    class LoadingState : State
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
