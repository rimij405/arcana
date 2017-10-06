using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.UIManagement
{ 
    /**
     * class CameOverState implements the state of the game when the end of the game
     * is triggered. It will display a screen object called "GameOverScreen" and
     * update frames as needed. When inputs are triggered to change the state of
     * the StageManager this screen will stop being displayed.
     **/
    class GameOverState: State
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
