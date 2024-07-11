using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour, IObstacles
{
    #region Vairable constants
    [SerializeField,Header("Obstacle movement speed"),Range(0,10)]
    public float speed;
    #endregion
    public void moveObstacle()
    {
        transform.position += Time.deltaTime * (Vector3.left *speed);
    }

    void Update()
    {
        moveObstacle();
    }
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
