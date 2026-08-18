using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChickenHealth : MonoBehaviour
{
    //public MeshRenderer meshRenderer;
    //public Color flashColor = Color.red;
    //public float flashDuration = 0.1f;
    [SerializeField] private int health;

    //private Color defaultColor;

    //private IEnumerator DoFlash()
    //{
       // meshRenderer.material.color = flashColor;
       // yield return new WaitForSeconds(flashDuration);
       // meshRenderer.material.color = defaultColor;
    //}

   // void Start()
    //{
    //    meshRenderer = GetComponentInChildren<MeshRenderer>();
    //    defaultColor = meshRenderer.material.color;
   // }

   // public void Flash()
   // {
   //     StopAllCoroutines();
   //     StartCoroutine(DoFlash());
   // }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }

        //StartCoroutine(DoFlash()); 
    }
}
