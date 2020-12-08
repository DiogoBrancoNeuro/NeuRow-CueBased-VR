using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBrush : MonoBehaviour
{
    public Vector3 BrushPosition;
    public float velocity;
    public GameObject Brush;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 60;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*velocity*Time.fixedDeltaTime);

        // Make it vibrate sometimes
        //	OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);

    }
}
