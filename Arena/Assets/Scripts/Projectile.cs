using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
	    if(col.collider.tag != "Bullet")
        {
            if(transform.childCount > 0)
            {
                transform.GetChild(0).GetComponent<ParticleSystem>().emissionRate = 0;
                transform.DetachChildren();
            }
            Destroy(gameObject);
        }
	}
}
