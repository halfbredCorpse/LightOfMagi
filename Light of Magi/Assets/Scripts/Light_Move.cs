using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Move : MonoBehaviour
{
    public Transform[] wayPointList;

    public int currentWayPoint = 0;
    Transform targetWayPoint;

    public float speed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (currentWayPoint < wayPointList.Length)
        {
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            Walk();
        }
	}

    void Walk()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);

        if (transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            targetWayPoint = wayPointList[currentWayPoint];

            if (currentWayPoint == wayPointList.Length)
                currentWayPoint = 0;
        }
    }
}
