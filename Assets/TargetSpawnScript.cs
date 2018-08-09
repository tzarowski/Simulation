using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnScript : MonoBehaviour {

    private GameObject[] activeTargets;
    public GameObject target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        activeTargets = GameObject.FindGameObjectsWithTag("TriggerExplosion");

        if(activeTargets.Length < 5)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-20f, 5f));

            Instantiate(target, spawnPosition, Quaternion.identity);
        }
        
	}
}
