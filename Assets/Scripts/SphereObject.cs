using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObject : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        transform.localScale *= 1.0005f;
    }
}
