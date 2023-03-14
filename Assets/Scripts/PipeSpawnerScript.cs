using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public LogicManagerScript logic;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
       
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                spawnPipe();
                timer = 0;
            }
        
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 vector3 = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);
        Instantiate(pipe, vector3, transform.rotation);
    }
}
