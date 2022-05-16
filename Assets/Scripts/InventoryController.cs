using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            panel.SetActive(!panel.activeInHierarchy);
            Time.timeScale = 1 - Time.timeScale;
            Debug.Log("New timescale is: " + Time.timeScale);
        }
    }
}
