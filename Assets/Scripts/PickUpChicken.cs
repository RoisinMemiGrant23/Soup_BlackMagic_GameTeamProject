using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUpChicken : MonoBehaviour
{
    [SerializeField] Transform HoldObj;
    private GameObject heldObj;
    private Rigidbody heldObjRB;

    [SerializeField] private float pickupRange = 5f;
    [SerializeField] private float pickupForce = 150f;

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.G))
       {
           if(heldObj == null)
           {
               RaycastHit hit;
               if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
               {
                   PickupObject(hit.transform.gameObject);
               }
           }
           else
           {
               DropObject();
           }
       }
       if(heldObj != null)
       {
           MoveObject();
       }
    }

    void MoveObject()
    {
        if(Vector3.Distance(heldObj.transform.position, HoldObj.position) > 0.1f)
        {
            Vector3 moveDirection = (HoldObj.position - heldObj.transform.position);
            heldObjRB.AddForce(moveDirection * pickupForce);
        }
    }
    
    void PickupObject(GameObject pickObj)
    {
        if(pickObj.GetComponent<Rigidbody>())
        {
            heldObjRB = pickObj.GetComponent<Rigidbody>();
            heldObjRB.useGravity = false;
            heldObjRB.linearDamping = 10;
            heldObjRB.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRB.transform.parent = HoldObj;
            heldObj = pickObj;
        }
    }

    void DropObject()
    {
        
            heldObjRB.useGravity = true;
            heldObjRB.linearDamping = 1;
            heldObjRB.constraints = RigidbodyConstraints.None;

            heldObj.transform.parent = null;
            heldObj = null;
        
    }
}