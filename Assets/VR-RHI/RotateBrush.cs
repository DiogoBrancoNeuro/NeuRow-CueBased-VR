using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBrush : MonoBehaviour
{
    public Vector3 BrushPosition;
    public float velocity;
    public GameObject Brush;
    public float a;
    public Vector3 OriginalRotation;
    public Vector3 Rotating;
    // Start is called before the first frame update
    void Start()
    {
        velocity = 60;
        OriginalRotation = GetComponent<Transform>().localRotation.eulerAngles;
        Rotating = Vector3.up * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Rotating * velocity);
        Debug.Log("Rotating: " + Rotating);
        Debug.Log("OriginalRotation: " + OriginalRotation);
        if (Rotating == OriginalRotation)
        {
            a++;
        }
        
        // Make it vibrate sometimes
        //	OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);

    }
}
