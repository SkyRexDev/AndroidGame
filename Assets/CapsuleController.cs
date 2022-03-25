using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour, Iinteractable
{
    public bool selected = false;
    public Renderer renderer;

    public void Drag(Ray the_ray)
    {
        throw new System.NotImplementedException();
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
            renderer.material.color = Color.yellow;
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
