using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        transform.eulerAngles += new Vector3 (0f, 1f, 0f);
    }
}
