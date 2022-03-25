using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour, Iinteractable
{
    public bool selected = false;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Tapped()
    {
        selected = !selected;

        if (selected)
        {
            renderer.material.color = Color.red;
        }

        else
        {
            renderer.material.color = Color.white;
        }
    }

    public void Drag(Ray the_ray)
    {
        RaycastHit info;
        if (Physics.Raycast(the_ray, out info))
        {
            if (info.transform.CompareTag("Plano"))
            {
                transform.position = the_ray.GetPoint(info.distance);
            }
        }
    }

    public void Pinch(Ray firstRay, Ray secondRay)
    {
        throw new System.NotImplementedException();
    }
}
