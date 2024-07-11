using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Unity Variables
    [SerializeField, Header("Player's upper force ammount"), Range(0f, 10f)]
    private float upperForceAmount = 3.0f;
    [SerializeField]
    private KeyCode _jumpButton = KeyCode.Space;
    [SerializeField]
    private Rigidbody2D _playerRigidBody;
    [SerializeField]
    private BoxCollider2D _playerCollider;
    private bool _inputDisabled = false;
    #endregion
    void Start()
    {
        //check if the rigidbody is being initialized by component.
        if (!this.gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigidBody))
        {
            this._playerRigidBody = gameObject.AddComponent<Rigidbody2D>();
            print($"{rigidBody} cannot be found, {_playerRigidBody.name} has been added.");
        }
        if (!this.gameObject.TryGetComponent<BoxCollider2D>(out BoxCollider2D boxCollider))
        {
            this._playerCollider = gameObject.AddComponent<BoxCollider2D>();
            print($"{boxCollider} cannot be found, {_playerCollider.name} has been added.");
        }
    }

    void Update()
    {
        //check if the keyboard input has been pressed.
        if (Input.GetKeyDown(_jumpButton) && !_inputDisabled)
        {
            _playerRigidBody.velocity = Vector3.up * upperForceAmount;
        }
    }
    #region logical methods
    public void DisableInput()
    {
        _inputDisabled = true;
        print("input has disabled");
    }
    #endregion
}
