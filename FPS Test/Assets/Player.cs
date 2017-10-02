using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    float vR = 0;
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	void Update ()
    {
        float speed = 5;
        float lookX = Input.GetAxis("Mouse X") * 2;
        float lookY = Input.GetAxis("Mouse Y") * 2;
        float left = Input.GetAxis("Horizontal") * speed;
        float forward = Input.GetAxis("Vertical") * speed;
        float jump = 0;

        CharacterController cc = GetComponent<CharacterController>();

        cc.transform.Rotate(new Vector3(0, lookX, 0));

        Vector3 motion = new Vector3(left, jump, forward);
        motion = cc.transform.rotation * motion;

        vR -= lookY;
        vR = Mathf.Clamp(vR, -60.0f, 90.0f + 60.0f);

        Camera.allCameras[0].transform.localRotation = Quaternion.Euler(vR, 0, 0);

        cc.SimpleMove(motion);
    }
}
