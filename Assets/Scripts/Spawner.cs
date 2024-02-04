using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fruit;
    public GameObject bombPrefab;
    public float spawnrate = 1;
    public float bombchance = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, spawnrate);
    }
    public void spawn()
    {
        var prefab = Random.Range(0,100) < (100 - bombchance) ? fruit : bombPrefab;

        var obj = Instantiate(prefab);
        var x = Random.Range(-5f, 5f);
        obj.transform.position = new Vector3(x, -5, 0);

    }
}
