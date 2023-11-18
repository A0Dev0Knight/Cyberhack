using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float MoveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir2D = Vector2.zero;

        if (Input.GetKey(KeyCode.D))
        {
            moveDir2D.x = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDir2D.x = -1;
        }
        
        moveDir2D = moveDir2D.normalized;
        Vector3 moveDir = new Vector3(moveDir2D.x,0, moveDir2D.y); 

        transform.position += moveDir*MoveSpeed*Time.deltaTime;
    }
}
