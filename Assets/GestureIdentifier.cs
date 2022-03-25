using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GestureIdentifier : MonoBehaviour
{
    // Start is called before the first frame update
    float timer;
    float maxTapTime = 0.2f;
    bool hasMoved;
    bool secondHasMoved;
    
    ITouchController[] theManager;
    void Start()
    {
        theManager = FindObjectsOfType<MonoBehaviour>().OfType<ITouchController>().ToArray();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Touch[] touches = Input.touches;

        if (Input.touchCount > 0)
        {
            Touch touch = touches[0];
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    timer = 0;
                    hasMoved = false;
                    break;

                case TouchPhase.Moved:
                    hasMoved = true;
                    print("I'm moving");
                    theManager[0].Drag(touch.position);
                    break;

                case TouchPhase.Ended:
                    if ((timer < maxTapTime) && !hasMoved)
                    {
                        theManager[0].Tap(touch.position);
                    }
                    break;
            }
        }

        if (Input.touchCount >= 2)
        {
            Touch firstTouch= touches[0];
            Touch secondTouch = touches[1];

            switch (secondTouch.phase)
            {

                case TouchPhase.Began:
                    secondHasMoved = true;
                    break;

                case TouchPhase.Stationary:
                case TouchPhase.Moved:
                    secondHasMoved = true;
                    theManager[0].Pinch(firstTouch.position, secondTouch.position);
                    break;

                case TouchPhase.Ended:
                    secondHasMoved = false;
                    theManager[0].PinchEnded();
                    break;
            }
        }
    }
}
