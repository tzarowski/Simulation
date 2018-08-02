﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticle : MonoBehaviour {

    public float explosionForce = 300f;
    public float lifetime;

	// Use this for initialization
	void Start () {
        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        float randomForce = Random.Range(0f, explosionForce);

        GetComponent<Rigidbody>().AddForce(randomDirection.normalized * randomForce);
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }

	}
}
