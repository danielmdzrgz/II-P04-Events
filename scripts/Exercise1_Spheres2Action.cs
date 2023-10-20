using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres2Action : MonoBehaviour
{
    private Transform self;
    public CylinderNotificator notificator;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Transform>();
        notificator.OnCubeEnter += moveToCylinder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveToCylinder()
    {   
        Vector3 direction = notificator.transform.position - self.position;
        direction.Normalize();
        direction.y = 0.0f;
        self.Translate(direction * speed * Time.deltaTime);
    }
}
