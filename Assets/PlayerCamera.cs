using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject sight;
    public GameObject gun;
    public GameObject targetPrefab;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        OVRInput.Update();
        Quaternion rControllerPos = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
        sight.transform.rotation = rControllerPos;
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            Bullet bullet = bulletObject.GetComponent<Bullet>();

            Vector3 shootingDirection = sight.transform.forward;

            bullet.shootingDirection = shootingDirection.normalized;

            Instantiate(targetPrefab);
            
        }

	}
}

