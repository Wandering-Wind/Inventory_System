using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragToBackpack : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject Parent;
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Assign the parent after the finish drag
        parentAfterDrag = transform.parent; 
        Debug.Log("BeginDrag");
        //Set the canvas as the parent during the drag
        transform.SetParent(transform.root);
        //To place it at the top of the view
        transform.SetAsLastSibling();
        image.raycastTarget = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        //First step is to move item while dragging
        transform.position = Input.mousePosition;
        //Unlink the item while dragging, and place it so that it will always be on the top of every object while dragging
        //So firstly, define a new variable (being the transform one)
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        Debug.Log("EndDrag");
    }
}
