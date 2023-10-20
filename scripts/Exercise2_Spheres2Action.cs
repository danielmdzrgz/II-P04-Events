using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres2Action2 : MonoBehaviour
{
    public CubeNotificator notificator;

    // Start is called before the first frame update
    void Start()
    {
        notificator.OnNotGroup1Enter += increaseSize;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void increaseSize()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
