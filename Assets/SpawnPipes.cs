using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2;
    private float timer = 2;
    public float offset = 15;


    void Start()
    {
        /*for (int i=1; i < 4; i++)
        {
            Vector3 pos = transform.position;
            pos.x = (float)55 / 3 * i;
            Instantiate(pipe, pos, transform.rotation);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate) timer += Time.deltaTime;
        else
        {
            timer = 0;
            Vector3 spawnPosition = transform.position;
            spawnPipe();
        }

    }
    void spawnPipe()
    {
        float lowMargin = transform.position.y - offset;
        float highMargin = transform.position.y + offset;
        Vector3 spawnPos = transform.position;
        spawnPos.y = Random.Range(lowMargin, highMargin);
        Instantiate(pipe, spawnPos, transform.rotation);

    }
}
