using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    public GameObject explodeparticles;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, Random.Range(10, 15));
        rb.angularVelocity = 200;
    }
     void Update()
    {
        if(transform.position.y < -6)
        {
            miss();
        }
    }
    void miss()
    {
        Destroy(gameObject);
        print(":D");
    }
    public void slice()
    {
        var particles = Instantiate(explodeparticles);
        particles.transform.position = transform.position;
        Destroy(gameObject);
    }

}
