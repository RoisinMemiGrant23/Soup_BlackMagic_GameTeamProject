using UnityEngine;

public class Onion : MonoBehaviour
{
	public GameObject OnionImage;

   private void OnTriggerEnter(Collider other)
   {
	   PlayerFoodInventory playerFoodInventory = other.GetComponent<PlayerFoodInventory>();

	   if(playerFoodInventory != null)
	   {
		   playerFoodInventory.OnionCollected();
		   gameObject.SetActive(false);
		   OnionImage.SetActive(true);
	   }
   }
}
