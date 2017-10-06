using UnityEngine;
using UI.UIManagement;
using Game.GameManager;
using Input.InputManager;
using System.Collections;

/**
 *  public class SystemController handles the 
 * 
 **/
public class SystemController : MonoBehaviour {

    // Create references to the UIManager, GameManager, and InputManager.
    UIManager _uiManager;
    GameManager _gameManager;
    InputManager _inputManager;

	// Initialize the ui, game, and input manager objects.
	void Start () {

        this._uiManager = new UIManager();
        this._gameManager = new GameManager();
        this._inputManager = new InputManager();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
