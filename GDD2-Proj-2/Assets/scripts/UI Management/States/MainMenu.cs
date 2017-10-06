using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManagement
{
    /**
      * class MainMenu implements the state of the game when the start of the game
      * is loaded. It will display a screen object called "MainMenuScreen" and
      * update frames as needed. When inputs are triggered to change the state of
      * the StageManager this screen will stop being displayed.
      **/
    class MainMenu : State
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
