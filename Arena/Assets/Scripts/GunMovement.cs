using UnityEngine;
using System.Collections;

public class GunMovement : MonoBehaviour {

    Vector2  defPos;
    Vector3 defaultEulerRotation;


    float shotTime = .5f;
    float shotTimer = 0;

	// Use this for initialization
	void Start () {
        defPos = transform.localPosition;
        defaultEulerRotation = transform.localEulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = transform.localPosition;
        newPos.x =  defPos.x + Camera.main.transform.localPosition.x;
        newPos.y = defPos.y + Camera.main.transform.localPosition.y;

        transform.localPosition = Vector3.Lerp(transform.localPosition, newPos, 2 * Time.deltaTime);

        Vector3 eulers = transform.localEulerAngles;
        eulers.y = Input.GetAxis("Mouse X") * 2.5f;
        eulers.z = Input.GetAxis("Mouse X") * -5f;
        eulers.x = Input.GetAxis("Mouse Y") * -5;
        //transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, defaultEulerRotation - eulers, 5 * Time.deltaTime);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(defaultEulerRotation - eulers), 5 * Time.deltaTime);


	}


}
