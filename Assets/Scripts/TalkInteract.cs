using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkInteract : Interactable
{
    public override void Interact(Player player)
    {
        Debug.Log("I am a sign!");
    }

}
