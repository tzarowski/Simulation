using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
    public Vector3 randomDirection;
    public float randomTime = 3;
    private float randY;
    private float randX;
    private float randZ;
    public float speed = 10;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Start()
    {
        randY = Random.Range(-1f, 1f);
        randX = Random.Range(-1f, 1f);
        randZ = Random.Range(-1f, 1f);

    }

	// Update is called once per frame
	void Update ()
    {
        randomTime -= Time.deltaTime;
        if(randomTime < 0)
        {
            randomTime = 1;
            randY = Random.Range(-1f, 1f);
            randX = Random.Range(-1f, 1f);
            randZ = Random.Range(-1f, 1f);
        }

        this.transform.Translate(Vector3.up * randY * Time.deltaTime * speed, Space.World);
        this.transform.Translate(Vector3.right * randX * Time.deltaTime * speed, Space.World);
        this.transform.Translate(Vector3.forward * randZ * Time.deltaTime * speed, Space.World);
    }

    void OnCollisionEnter (Collision collision)
    {
        if(collision.transform.tag == "Bullet")
        {
            Instantiate(explosionPrefab, collision.transform);
            ScoreManagerScript.score += 1;
            Destroy(gameObject);
            
        }
    }

}
