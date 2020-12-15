using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBrush : MonoBehaviour
{
    public Vector3 BrushPosition;
    public float velocity=60;
    public GameObject Brush;
    public float a;
    public Vector3 OriginalRotation;
    public Vector3 Rotating;
    public Vector3 LastRotationPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
        velocity = 30;
        OriginalRotation = GetComponent<Transform>().rotation.eulerAngles;
        Rotating = Vector3.up * Time.deltaTime * velocity;


    }

    public void RotationPosition(string a)
    {
        switch (a)
        {
            case "0":
                Rotating = Vector3.down * Time.deltaTime * velocity;
                break;
            case "1":
                Rotating = Vector3.up * Time.deltaTime * velocity;
                break;
        }
        FixedUpdate();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        transform.Rotate(Rotating);
        



        // Send a trigger to the eeg, everytime the brush touches the hand.
        // Make it vibrate sometimes
        //	OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);

    }
    
}
