using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Drag : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DragHandler(BaseEventData data)
    {
        if (!GameManager.instance.isMoving) {
            PointerEventData pointerEventData = (PointerEventData)data;

            Vector3 position;
            RectTransformUtility.ScreenPointToWorldPointInRectangle(
                (RectTransform)canvas.transform,
                pointerEventData.position,
                canvas.worldCamera,
                out position
            );

            transform.position = position;
        }
    }
}
