using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; // vị trí mục tiêu
    public float speed = 1.0f; // tốc độ di chuyển

    public float minDistance = 0.1f;
    public float speed2 = 90f;
    private bool isMoving;

    void Start()
    {
        // agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); // get navmesh agent component
        isMoving = true; // set initial value of isMoving
                         // set initial value of isNear
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the target is not null and the distance is greater than the minimum
        if (target != null && Vector3.Distance(transform.position, target.position) > minDistance)
        {
            // Calculate the direction vector from the current position to the target position
            Vector3 direction = (target.position - transform.position).normalized;

            // Calculate the movement vector based on the speed and the time between frames
            Vector3 movement = direction * speed * Time.deltaTime;

            // Move the object by adding the movement vector to the current position
            transform.position += movement;
            isMoving = true;
        }
        if (target != null && Vector3.Distance(transform.position, target.position) <= minDistance)
        {

            isMoving = false;
        }


       

    }


    // The head object to rotate



}
