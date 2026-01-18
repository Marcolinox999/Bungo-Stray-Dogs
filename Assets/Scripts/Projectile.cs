using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] int speed;
    private List<Vector3> patrolPoints = new List<Vector3>();
    [SerializeField] private Transform patrolPath;
    private int currentIndex = 0;
    void Awake()
    {
        foreach (Transform child in patrolPath)
        {
            patrolPoints.Add(child.position);
        }
        
        transform.eulerAngles = transform.position.x > patrolPoints[currentIndex].x ? new Vector3(0, 180, 0) : Vector3.zero;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentIndex], speed * Time.deltaTime);
        
        if (transform.position == patrolPoints[currentIndex]) 
        {
        }  
    }
}
