using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHit : ToolHit
{
    [SerializeField] GameObject pickUpDrop;
    [SerializeField] int pickupCount = 5;
    [SerializeField] float spread = 0.5f; 

    public override void Hit()
    {
        while (pickupCount > 0)
        {
            pickupCount -= 1;
            Vector3 position = transform.position;
            position.x += spread * UnityEngine.Random.value - spread / 2;
            position.y += spread * UnityEngine.Random.value - spread / 2;
            GameObject go = Instantiate(pickUpDrop);
            go.transform.position = position;
        }
        Destroy(gameObject);
    }
}
