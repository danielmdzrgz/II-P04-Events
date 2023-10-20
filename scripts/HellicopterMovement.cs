using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellicopterMovement : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        moveDirection = new Vector3(0, verticalMovement * speed * Time.deltaTime, horizontalMovement * speed * Time.deltaTime);
        transform.Translate(moveDirection);
    }
}
