using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Path Variables 
    [SerializeField] Waypoints waypoints;
    private int waypointIndex;

    //Variables 
    [SerializeField] private float moveSpeed = 5.0f;
    private float turnRate = 90;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = GameObject.FindGameObjectWithTag("Waypoint").GetComponent<Waypoints>();
    }

   
   

    // Update is called once per frame
    void Update()
    {
        MoveAlongWaypoints();
    }


    void MoveAlongWaypoints()
    {
        Vector3 targetPosition = waypoints.waypoints[waypointIndex].position;

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        Vector3 direction = targetPosition - transform.position;
        float turnAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(turnAngle, Vector3.forward);

        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (waypointIndex < waypoints.waypoints.Length - 1)
            {
                waypointIndex++;
            } 
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
