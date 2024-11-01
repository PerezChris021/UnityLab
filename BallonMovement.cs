using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BallonMovement : MonoBehaviour
{
    public int health = 100;

    [SerializeField] float speed;
    [SerializeField] float maxDistance;
    [SerializeField] float range;

    Vector2 wayPoint;
     void Start()
    {
        SetNewDestination();
    }

     void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed*Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
            SetNewDestination();
    }
    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }





    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    
}
