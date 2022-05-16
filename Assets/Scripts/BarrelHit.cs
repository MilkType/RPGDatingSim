using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHit : ToolHit
{
    [SerializeField] GameObject pickUpDrop;
    [SerializeField] float spread = 0.5f;

    [SerializeField] Item item;
    [SerializeField] int itemCountPerDrop = 1;
    [SerializeField] int pickupCount = 5;

    public override void Hit()
    {
        while (pickupCount > 0)
        {
            pickupCount -= 1;
            Vector3 position = transform.position;
            position.x += spread * UnityEngine.Random.value - spread / 2;
            position.y += spread * UnityEngine.Random.value - spread / 2;
            
            ItemSpawnManager.instance.SpawnItem(position, item, itemCountPerDrop);
        }
        Destroy(gameObject);
    }
}
