using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private UIManager _uiManager;
    private InputManager _inputManager;
    void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider != null)
        {
            switch (collider.transform.tag)
            {
                case "Score":
                    {
                        _uiManager.IncreaseScore();
                        break;
                    }
                case "Obstacle":
                    {
                        _uiManager.DisplayGameOverMessage();
                        _inputManager.DisableInput();
                        break;
                    }
            }
        }
    }
}
