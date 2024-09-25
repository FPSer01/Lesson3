using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleObject : MonoBehaviour, IInteractable
{
    [SerializeField] Renderer capsuleMat;

    public void Interact()
    {
        capsuleMat = GetComponent<Renderer>();
        capsuleMat.material.color = Color.blue;
    }
}
