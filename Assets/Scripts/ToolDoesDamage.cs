using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToolDoesDamage : MonoBehaviour
{
    [SerializeField] private float toolHitRadius;
    [SerializeField] private Transform toolHitPoint;
    [SerializeField] private int damage = 1;
    [SerializeField] private GameObject hitEffect;

    [SerializeField] private LayerMask targetLayer;

    [SerializeField] private Animator animator;
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Idle");
        }
    }

    public void DetectHit()
    {
        Collider[] hit = Physics.OverlapSphere(toolHitPoint.position,toolHitRadius, targetLayer);

        if(hit.Length > 0)
        {
            hit[0].GetComponent<ChickenHealth>().TakeDamage(damage);
            Instantiate(hitEffect.transform, hit[0].transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
        }
    }
}
