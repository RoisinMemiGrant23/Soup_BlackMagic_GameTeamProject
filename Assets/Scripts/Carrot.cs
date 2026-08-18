using UnityEngine;

public class Carrot : MonoBehaviour
{
	public GameObject CarrotImage;

   private void OnTriggerEnter(Collider other)
   {
	   PlayerFoodInventory playerFoodInventory = other.GetComponent<PlayerFoodInventory>();

	   if(playerFoodInventory != null)
	   {
		   playerFoodInventory.CarrotCollected();
		   gameObject.SetActive(false);
		   CarrotImage.SetActive(true);
	   }
   }
}
