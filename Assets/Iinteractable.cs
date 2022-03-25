using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Iinteractable
{
    public void Tapped();
    public void Drag(Ray the_ray);
    public void Pinch(Ray firstRay, Ray secondRay);
}
