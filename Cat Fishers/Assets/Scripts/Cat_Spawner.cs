using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Spawner : MonoBehaviour {

    public GameObject[] cats;
    //public Vector2 spawnValues;
    public Vector3 spawnValues;
    public float WaitTime;
    public float WaitMost;
    public float WaitLeast;
    public int startWait;
    public bool stop;

    private int randCat;
    //constant movement for cats
    private bool rightDir;

	void Start ()
    {
        rightDir = true;
        StartCoroutine(WaitForSpawn());
	}
	
	
	void Update ()
    {
        WaitTime = Random.Range(WaitMost, WaitLeast);

	}

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randCat = Random.Range(0, 3);

            //Vector2 position = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), 0);
            Vector3 position = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(cats[randCat], position + transform.TransformPoint(0,0,0), gameObject.transform.rotation);

            yield return new WaitForSeconds(WaitTime);
        }
    }
}
