using UnityEngine;

public class Apple : MonoBehaviour
{
   public GameObject AppleImage;

   private void OnTriggerEnter(Collider other)
   {
	   PlayerFoodInventory playerFoodInventory = other.GetComponent<PlayerFoodInventory>();

	   if(playerFoodInventory != null)
	   {
		   playerFoodInventory.AppleCollected();
		   gameObject.SetActive(false);
		   AppleImage.SetActive(true);
	   }
   }
}
