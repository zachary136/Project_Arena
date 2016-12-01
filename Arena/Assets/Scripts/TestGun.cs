using UnityEngine;
using System.Collections;

public class TestGun : MonoBehaviour {

    public Transform bulletSpawnPoint;
    public int numberOfBullets;

    public GameObject Bullet;
    public float projectileSpeed;

    public AudioSource shotSnd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetTrigger("Shoot");
            Shoot();
        }
	}

    void Shoot()
    {
        Transform camTrans = Camera.main.transform;
        shotSnd.Play();
        for(int i = 0; i < numberOfBullets; i++)
        {
            RaycastHit hit;
            float A = Random.Range(-.1f, .1f);
            Vector3 shotDir = (camTrans.right * Random.Range(-.1f, .1f)) + (camTrans.up * Random.Range(-.1f, .1f));
            if(Physics.Raycast(camTrans.position, camTrans.forward + shotDir, out hit, Mathf.Infinity))
            {
                GameObject p = (GameObject)Instantiate(Bullet, bulletSpawnPoint.position, Quaternion.identity);
                p.GetComponent<Rigidbody>().velocity = (hit.point - transform.position).normalized * Random.Range(200, 250);
            }
        }
    }
}
