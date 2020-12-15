using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushTrigger : MonoBehaviour
{
    public GameObject collisionobject;
    public int a;
    GameObject tcp;
    public GameObject LeftGripHand;
    public List<string> TriggersList;
    public void Start()
    {
        LeftGripHand = GameObject.FindGameObjectWithTag("BrushLeft");
        tcp = GameObject.Find("TCP");
        

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "CollisionObjectTrigger")
        {
            Debug.Log("TriggerCollision");
            tcp.GetComponent<TCPTestClientPython>().clientMessage = "180";
            tcp.GetComponent<TCPTestClientPython>().SendMessage();
            gameObject.GetComponent<RotateBrush>().RotationPosition("0");
            LeftGripHand.GetComponent<RotateBrushLeft>().RotationPosition("0");
            TriggersList.Add(other.gameObject.tag);

        }
        else if (other.gameObject.tag == "CollisionObjectDown")
        {
            tcp.GetComponent<TCPTestClientPython>().clientMessage = "0";
            tcp.GetComponent<TCPTestClientPython>().SendMessage();
            Debug.Log("Collision");
            gameObject.GetComponent<RotateBrush>().RotationPosition("1");
            LeftGripHand.GetComponent<RotateBrushLeft>().RotationPosition("1");
            TriggersList.Add(other.gameObject.tag);
        }
    }
    IEnumerable ResetServoPosition()
    {
        yield return new WaitForSeconds(0);
        tcp.GetComponent<TCPTestClientPython>().clientMessage = "0";
        tcp.GetComponent<TCPTestClientPython>().SendMessage();
    }




}
