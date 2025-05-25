using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerScript : MonoBehaviour
{
    float xrotation;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //reading Mouse Input
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");
        //Assign Mouse Y Movement to xrotation
        xrotation -= MouseY;
        //clamping Mouse Y movement
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        //local Rotation
        transform.localRotation = Quaternion.Euler(xrotation,0f,0f);
        //Assigning Player to the MouseX movement
        Player.Rotate(Vector3.up * MouseX);
    }
}
