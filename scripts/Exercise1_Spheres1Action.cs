using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres1Action : MonoBehaviour
{
    public CylinderNotificator notificator;

    // Start is called before the first frame update
    void Start()
    {
        notificator.OnCubeEnter += changeColor;
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
}
