using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUp : MonoBehaviour
{
   public GameObject pickUpText;
   public GameObject AxeImage;
   public GameObject AxeOnPlayer;
   public GameObject Axe;

   void Start()
   {
	   pickUpText.SetActive(true);
	   AxeOnPlayer.SetActive(false);
   }

   private void OnTriggerStay(Collider other)
   {
	   if (other.gameObject.CompareTag("Player"))
	   {
		   pickUpText.SetActive(true);
	   }
	   if (Input.GetKey(KeyCode.E))
	   {
	      //gameObject.SetActive(false);
	      AxeOnPlayer.SetActive(true);
	      pickUpText.SetActive(false);
		  AxeImage.SetActive(true);
		  Destroy(Axe);
	   } 
   }


   private void OnTriggerExit(Collider other)
   {
	   if (other.gameObject.CompareTag("Player"))
	   {
		   pickUpText.SetActive(false);
	   }
   }

}

