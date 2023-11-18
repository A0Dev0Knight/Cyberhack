using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractLogic : MonoBehaviour
{
    [SerializeField] float InteractDistance = 2f;
    [SerializeField] LayerMask ColliderFilter;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D collider2D = Physics2D.OverlapCircle(transform.position, InteractDistance, ColliderFilter);
            if (collider2D != null) { Debug.Log("Next Scene!"); }
        }
    }
}