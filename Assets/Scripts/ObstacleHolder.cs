using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHolder : MonoBehaviour, IObstacles
{
    [SerializeField,Header("Obstacle movement speed"),Range(0,10)]
    public float speed = 3f;

    public void InitiateRandomPosition()
    {
        Vector3 newPosition = new Vector3(transform.position.x, -(Random.Range(3.3f, 4.5f)), transform.position.z);
        transform.position = newPosition;
    }

    public void MoveObstacle()
     {
         transform.position += Time.deltaTime * (Vector3.left *speed);
     }
    void Start()
    {
        if (speed == 0) speed = 3f;
        InitiateRandomPosition();
    }
    void Update()
     {
         MoveObstacle();
     }

}
