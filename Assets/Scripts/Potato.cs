using UnityEngine;

public class Potato : MonoBehaviour
{
	public GameObject PotatoImage;

   private void OnTriggerEnter(Collider other)
   {
	   PlayerFoodInventory playerFoodInventory = other.GetComponent<PlayerFoodInventory>();

	   if(playerFoodInventory != null)
	   {
		   playerFoodInventory.PotatoCollected();
		   gameObject.SetActive(false);
		   PotatoImage.SetActive(true);
	   }
   }
}
