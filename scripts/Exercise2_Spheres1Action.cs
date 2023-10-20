using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres1Action2 : MonoBehaviour
{
    public CubeNotificator notificator;
    public GameObject cylinder;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        notificator.OnGroup1Enter += moveToCylinder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveToCylinder()
    {   
        Vector3 direction = cylinder.transform.position - transform.position;
        direction.Normalize();
        direction.y = 0.0f;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
