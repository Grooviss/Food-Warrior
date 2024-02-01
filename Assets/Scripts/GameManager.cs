using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fruit;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2f, 1f);
    }
    void spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-5, 5), 0, 0);
        Instantiate(fruit, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
