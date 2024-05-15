using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackpackSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {

            //This method is triggered when something is dropped on the object
            GameObject dropped = eventData.pointerDrag;
            //So now what we can do is modify parentAfterDrag variable from DragToBackpack Script
            //Item will be assigned to the new parent
            DragToBackpack draggableItem = dropped.GetComponent<DragToBackpack>();
            draggableItem.parentAfterDrag = transform;
            //hide the object getting dragged during the from any of the mouse inputs
            //so that it drops it to the object below

            //Create a if statement to check if there are any children in the slot ot avoid stacking
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
