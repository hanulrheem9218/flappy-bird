using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour //, IObstacles
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            switch (collision.transform.tag)
            {
                case "Player":
                    {
                        collision.transform.SendMessage("DisableInput");
                        break;
                    }
            }
        }
    }
}
