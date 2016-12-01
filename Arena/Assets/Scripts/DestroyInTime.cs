using UnityEngine;
using System.Collections;

public class DestroyInTime : MonoBehaviour {

    public int time = 2;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
	
}
