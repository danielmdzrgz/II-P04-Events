using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderNotificator : MonoBehaviour
{
    public delegate void action();
    public event action OnCubeEnter; 
    public event action OnCubeProximity;

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = cube.transform.position - transform.position;
        if (distance.magnitude < 2.5f)
        {   
            OnCubeProximity();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "MyCube")
        {
            OnCubeEnter();
        }
    }
}
