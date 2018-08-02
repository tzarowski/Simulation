﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float shootingForce = 10f;
    public Vector3 shootingDirection;
    public float lifetime = 3f;
    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;
        if(lifetime <= 0)
        {
            Destroy(gameObject);
        }
	}
    /*
    void OnCollisionEnter (Collision collision)
    {
        if(collision.transform.tag == "TriggerExplosion")
        {
            
            GameObject explosionObject = Instantiate(explosionPrefab);
            explosionObject.transform.position = transform.position;

        }
    }
    */
}
