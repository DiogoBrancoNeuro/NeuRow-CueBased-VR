using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushTrigger : MonoBehaviour
{
    public GameObject collisionobject;
    public int a;
    GameObject tcp;
    public void Start()
    {
        
        tcp = GameObject.Find("TCP");
        

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "CollisionObjectTrigger")
        {
            Debug.Log("TriggerCollision");
            tcp.GetComponent<TCPTestClientPython>().clientMessage = "100";
            tcp.GetComponent<TCPTestClientPython>().SendMessage();
            

        }
    }
    IEnumerable ResetServoPosition()
    {
        yield return new WaitForSeconds(0);
        tcp.GetComponent<TCPTestClientPython>().clientMessage = "0";
        tcp.GetComponent<TCPTestClientPython>().SendMessage();
    }




}
