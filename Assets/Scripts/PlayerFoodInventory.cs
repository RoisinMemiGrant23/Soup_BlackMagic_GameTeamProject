using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerFoodInventory : MonoBehaviour
{
	public int NumberOfApples { get; private set; }
	public int NumberOfOnions { get; private set; }
	public int NumberOfPotatoes { get; private set; }
	public int NumberOfCarrots { get; private set; }

	public void AppleCollected()
	{
		NumberOfApples++;
	}

	public void OnionCollected()
	{
		NumberOfOnions++;
	}

	public void PotatoCollected()
	{
		NumberOfPotatoes++;
	}

	public void CarrotCollected()
	{
		NumberOfCarrots++;
	}
}
