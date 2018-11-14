using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path_Finder : MonoBehaviour
{

    private float speed = 2f;
    private Transform target;
    private int wayPointIndex = 0;
    private LifePoints _life;

    private void Awake()
    {
        _life = FindObjectOfType<LifePoints>();
    }

    private void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime);



        if (Vector3.Distance(transform.position, target.position) <= 0.1)
        {
            getnextWaypoint();
        }
    }
    void getnextWaypoint()
    {
        if (wayPointIndex >= Waypoints.points.Length - 1)
        {
            _life.lifeValue -= 1;
            Destroy(gameObject);

            return;
        }


        wayPointIndex++;
        target = Waypoints.points[wayPointIndex];

    }
}