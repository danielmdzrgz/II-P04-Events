using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres2Action3 : MonoBehaviour
{
    public CylinderNotificator notificator;
    public GameObject myObject;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        notificator.OnCubeProximity += moveToObject;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveToObject()
    {   
        Vector3 direction = myObject.transform.position - transform.position;
        direction.Normalize();
        direction.y = 0.0f;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
