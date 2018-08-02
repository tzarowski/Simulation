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
            Instantiate(target);
        }
        
	}
}
