using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject targetPrefab;
    public Transform barrel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            shootBullet(); 
        }
        
    }

    void shootBullet()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, barrel.position, barrel.rotation);
        Bullet bullet = bulletObject.GetComponent<Bullet>();

        bullet.shootingDirection = barrel.forward.normalized;
    }

    void traceRay()
    {
        RaycastHit hit;
        LineRenderer lineR = this.GetComponent<LineRenderer>();

        lineR.SetPosition(0, barrel.position);

        if (Physics.Raycast(barrel.position, barrel.forward, out hit, Mathf.Infinity))
        {
            lineR.SetPosition(1, hit.point);
        }
        else
        {
            lineR.SetPosition(1, barrel.position);
        }
    }

}
