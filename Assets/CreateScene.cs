using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScene : MonoBehaviour
{
    GameObject sphere, capsule, plane, cube, manager;
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        manager = new GameObject("Manager");
        manager.AddComponent<TouchManager>();
        manager.AddComponent<GestureIdentifier>();

        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.AddComponent<SphereController>();
        sphere.transform.position = new Vector3(2, 1, 0);

        capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.AddComponent<CapsuleController>();
        capsule.transform.position = new Vector3(-4, 1, 0);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<CubeController>();
        cube.transform.position = new Vector3(0f, 1.5f, 0.62f);

        plane = GameObject.CreatePrimitive(PrimitiveType.Plane);

    }
    
}