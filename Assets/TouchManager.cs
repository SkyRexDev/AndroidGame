using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour, ITouchController
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    public void Tap(Vector2 pos)
    {
        //print("InTapo");
        Ray our_ray = Camera.main.ScreenPointToRay(pos);
        RaycastHit info;
        if (Physics.Raycast(our_ray, out info))
        {

            Iinteractable selectedObject = info.transform.GetComponent<Iinteractable>();
           
            if(selectedObject!=null)
            {
                info.transform.GetComponent<Iinteractable>().Tapped();
            }
        }

    }

    public void Drag(Vector2 position)
    {
        Ray our_ray = Camera.main.ScreenPointToRay(position);
        RaycastHit info;
        if (Physics.Raycast(our_ray, out info))
        {

            Iinteractable selectedObject = info.transform.GetComponent<Iinteractable>();

            if (selectedObject != null)
            {
                Ray myRay = Camera.main.ScreenPointToRay(position);
                selectedObject.Drag(myRay);
            }
        }

    }

    public void Pinch(Vector2 firstTouch, Vector2 secondTouch)
    {
        throw new System.NotImplementedException();
    }

    public void PinchEnded()
    {
        throw new System.NotImplementedException();
    }
}
