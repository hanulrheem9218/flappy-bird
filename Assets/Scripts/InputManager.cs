using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Unity Variables
    [SerializeField, Header("Player's upper force ammount"),Range(0f,10f)]
    private float upperForceAmount = 3.0f;
    [SerializeField]
    private KeyCode _jumpButton = KeyCode.Space;
    [SerializeField]
    private Rigidbody _playerRigidBody;
    #endregion
    void Start()
    {
        //check if the rigidbody is being initialized by component.
        if (!this.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rigidBody))
        {
            this._playerRigidBody = gameObject.AddComponent<Rigidbody>();
            print("Rigidbody has been added.");

        }

    }

    void Update()
    {
        //check if the keyboard input has been pressed.
        if (Input.GetKeyDown(_jumpButton))
        {
            _playerRigidBody.velocity = Vector3.up * upperForceAmount;  
        }
    }
}
