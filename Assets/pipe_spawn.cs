using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawn = 2;
    public float time=0;
    public float high = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawn)
        {
            time += Time.deltaTime;
        }
        else
        {

            spawnpipe();
            time= 0;
        }
    }
    void spawnpipe()
    {   
        float highest= transform.position.y + high;
        float lowest = transform.position.y - high;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(highest,lowest),0), transform.rotation);

    }
}
