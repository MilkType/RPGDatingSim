using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractController : MonoBehaviour
{
    PlayerController playerController;
    Rigidbody2D rgdbd2d;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 1.2f;
    Player player;

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        rgdbd2d = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Interact();
        }
    }

    private void Interact()
    {
        Vector2 position = rgdbd2d.position + playerController.lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            Interactable hit = c.GetComponent<Interactable>();
            if (hit != null)
            {
                hit.Interact(player);
                break;
            }
        }
    }
}
