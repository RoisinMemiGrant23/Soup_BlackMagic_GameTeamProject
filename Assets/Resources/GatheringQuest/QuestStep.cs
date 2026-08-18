using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class QuestStep : MonoBehaviour
{
    private bool isFinished = false;

    protected void FinishQuestStep()
    {
        if(!isFinished)
        {
            isFinished = true;

            Destroy(this.gameObject);
        }   
    }
}
