using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform point;
    public GameObject prefab;
    private float timebetweenSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.80f;
    

    
   
    // Update is called once per frame
    void Update()
    {
        
        if (timebetweenSpawn <= 0)
        {
            float rand = UnityEngine.Random.Range(1f,2f);
            float ran = UnityEngine.Random.Range(2f, 4f);
            Invoke("Spawn", ran);
            timebetweenSpawn = startTimeBtwSpawn +rand ;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }

        }
        else
        {
            timebetweenSpawn -= Time.deltaTime;
        }
    }
    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
