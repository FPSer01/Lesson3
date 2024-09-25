using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderObject : MonoBehaviour, IInteractable
{
    public GameObject objectText;

    public void Interact()
    {
        objectText.SetActive(true);
    }
}
