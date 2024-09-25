using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactRadius;

    void Update()
    {
        Collider[] objs = Physics.OverlapSphere(transform.position, interactRadius);

        if (objs.Length > 0)
        {
            foreach (Collider obj in objs)
            {
                IInteractable interactable = obj.gameObject.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactRadius);
    }
}
