using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Interact : MonoBehaviour
{

    public Animator Chest;
    public Animator Skelly;

    public void StartChestAnimation()
    {
        if (Chest != null)
        {
            Chest.Play("ChestOpen");
        }
    }


    public void StartSkellyAnimation()
    {
        if(Skelly != null)
        {
            Skelly.Play("MonsterHit");
        }
        
    }


}
