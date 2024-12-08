using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        BallonMovement b1  =  hitInfo.GetComponent<BallonMovement>();
        if (b1 != null)
        {
            b1.TakeDamage(100);
        }
        Destroy(gameObject);
    }


}
