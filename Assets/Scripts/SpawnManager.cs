using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    List<ObstacleController> obstacles;
    [SerializeField]
    private Transform _startSpawnPosition;
    [SerializeField]
    private Transform _endSpawnPosition;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            switch(collision.gameObject.tag)
            {
                case "Obstacle":
                    {
                        Vector3 newPosition = new Vector3(_startSpawnPosition.position.x, -(Random.Range(2.5f, 4.9f)), _startSpawnPosition.position.z);
                        collision.gameObject.transform.position = newPosition;
                        print("Obstacle position has changed");
                        break;
                    }
            }
        }
    }
}
