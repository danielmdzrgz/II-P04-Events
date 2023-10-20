using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres1Action3 : MonoBehaviour
{
    public CylinderNotificator notificator;
    public float jumpForce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        notificator.OnCubeProximity += eventHandler;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = newColor;
    }

    void jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }

    void eventHandler()
    {
        changeColor();
        jump();
    }
}
