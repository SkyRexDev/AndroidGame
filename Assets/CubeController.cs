using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour, Iinteractable
{
    public bool selected = false;
    public bool dragged = false;
    public float distance; 
    public Renderer renderer;

    public void Drag(Ray the_ray)
    {
        if (dragged)
        {
            transform.position = the_ray.GetPoint(distance);
        }
        else
        {
            dragged = true;
            distance = Vector3.Distance(the_ray.origin, transform.position);
        }
    }

    public void Pinch(Ray firstRay, Ray secondRay)
    {
        throw new System.NotImplementedException();
    }

    public void Tapped()
    {
        selected = !selected;

        if (selected)
        {
            renderer.material.color = Color.blue;
        }

        else
        {
            renderer.material.color = Color.white;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
