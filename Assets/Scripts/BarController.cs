using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BarController : MonoBehaviour
{
    private bool onHold = false;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGameOver && !GameManager.instance.isMoving)
            if (Input.GetMouseButton(0) && onHold )
                moveWithMouse();
                
    }

    // rotates an object accoring to mouse position
    public void moveWithMouse()
    {
        Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 v2 = new Vector2(p.x - transform.position.x, p.y - transform.position.y);
        transform.right = v2;
    }


    public void pointerDownHandler(BaseEventData data)
    {
        onHold = true;
    }

    public void pointerUpHandler(BaseEventData data)
    {
        onHold = false;
    }

}
