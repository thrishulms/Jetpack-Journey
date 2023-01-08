using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public float maxTime = 5f;
    public float timer = 0f;
    public GameObject walls;
    public float height = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            var wall = Instantiate(walls);
            wall.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(wall, 15);
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
