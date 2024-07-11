using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField,Header("Obstacle movement speed"),Range(0,10)]
    public float speed = 3.0f;

    void Start()
    {
        if (speed == 0) { speed = 3.0f; }
        Vector3 newPosition = new Vector3(transform.position.x, -(Random.Range(3.3f, 4.5f)), transform.position.z);
        transform.position = newPosition;
    }
    void Update()
     {
        transform.position += Time.deltaTime * (Vector3.left * speed);
    }

}
