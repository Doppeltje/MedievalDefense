using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_On : MonoBehaviour
{

    [SerializeField]
    GameObject shootPos;

    public GameObject target = null;

    private float closestX;
    private float closestY;

    public float distanceToClosestEnemy = Mathf.Infinity;
    //public float distanceToClosestEnemy = 0f;

    public float targetX;
    public float targetY;
    public Quaternion rotation;

    [SerializeField]float disA;

    [SerializeField]float towerRange = 6f;

    // allEnemies to index
    public List<GameObject> enemies = new List<GameObject>();

    private float x;
    private float y;

    public bool gotTarget = false;

    private void Start()
    {

    }

    void Update()
    {
        if (!target)
        {

            gotTarget = false;
            //Debug.Log("Target == null");
            target = GetClosestEnemy();
        }

        if (target)
        {            
            //disA = (transform.position - target.transform.position).magnitude / 20;

                gotTarget = true;
                Debug.DrawLine(transform.position, target.transform.position);
                targetX = target.transform.position.x;
                targetY = target.transform.position.y;
        }

    }


    GameObject GetClosestEnemy()
    {
        float dis = Mathf.Infinity;
        float closestDis = Mathf.Infinity;
        GameObject closestEnemy = null;

        List<GameObject> enemies = new List<GameObject>();
            enemies.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));

        foreach (GameObject enemy in enemies)
        {
            dis = (transform.position - enemy.transform.position).magnitude;
            {
                if (dis < closestDis)
                {
                    closestDis = dis;
                    closestEnemy = enemy;
                }
            }
        }
        return closestEnemy;

    }
    
}
