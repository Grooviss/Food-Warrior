using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slicer : MonoBehaviour
{
    Rigidbody2D rb;

     void Start()
    {
        if(!Application.isEditor)Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        var worldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldpos.z = 0;

        //transform.position = worldpos;
        rb.MovePosition(worldpos);
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        var fruit = other.gameObject.GetComponent<fruit>();
        fruit.slice();
    }

}
