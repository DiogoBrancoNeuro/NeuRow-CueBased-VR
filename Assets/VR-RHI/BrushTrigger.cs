using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushTrigger : MonoBehaviour
{
    public GameObject collisionobject;
    public int a;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollisionObjectTrigger")
            Debug.Log("TriggerCollision");
    }
    

}
