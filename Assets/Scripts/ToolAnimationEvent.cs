using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToolAnimationEvent : MonoBehaviour
{
    private ToolDoesDamage toolDoesDamage;

    void Start()
    {
        toolDoesDamage = GetComponentInParent<ToolDoesDamage>();
    }

    void Damage()
    {
        toolDoesDamage.DetectHit();
    }
}
