using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResellScript : MonoBehaviour, IDropHandler
{
    public GameObject Potion;
    public GameObject Compass;
    public GameObject Map;
    public GameObject Grimoire;
    public Text CoinsTxt;
    public ShopManagerScript shopManagerScipt;
    //The same code used from my BackpackSlot Script
    public void OnDrop(PointerEventData eventData)
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        

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

            if (dropped.CompareTag("Potion"))
            {
                Debug.Log("Sell Potion");
                //Add the coins player has
                shopManagerScipt.coins += shopManagerScipt.shopItems[2, ButtonRef.GetComponent<ButtonManager>().ItemID];
                //Increase the Quantity
                shopManagerScipt.shopItems[3, ButtonRef.GetComponent<ButtonManager>().ItemID]++;
                //Update our text
                CoinsTxt.text = "Coins: " + shopManagerScipt.coins.ToString();

            }

            if (dropped.CompareTag("Compass"))
            {
                Debug.Log("Sell Compass");
                //Add the coins player has
                shopManagerScipt.coins += shopManagerScipt.shopItems[2, ButtonRef.GetComponent<ButtonManager>().ItemID];
                //Increase the Quantity
                shopManagerScipt.shopItems[3, ButtonRef.GetComponent<ButtonManager>().ItemID]++;
                //Update our text
                CoinsTxt.text = "Coins: " + shopManagerScipt.coins.ToString();
            }

            if (dropped.CompareTag("Grimoire"))
            {
                Debug.Log("Sell Grimoire");
                //Add the coins player has
                shopManagerScipt.coins += shopManagerScipt.shopItems[2, ButtonRef.GetComponent<ButtonManager>().ItemID];
                //Increase the Quantity
                shopManagerScipt.shopItems[3, ButtonRef.GetComponent<ButtonManager>().ItemID]++;
                //Update our text
                CoinsTxt.text = "Coins: " + shopManagerScipt.coins.ToString();
            }

            if (dropped.CompareTag("Map"))
            {
                Debug.Log("Sell Map");
                //Add the coins player has
                shopManagerScipt.coins += shopManagerScipt.shopItems[2, ButtonRef.GetComponent<ButtonManager>().ItemID];
                //Increase the Quantity
                shopManagerScipt.shopItems[3, ButtonRef.GetComponent<ButtonManager>().ItemID]++;
                //Update our text
                CoinsTxt.text = "Coins: " + shopManagerScipt.coins.ToString();
            }

            Destroy(dropped);
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
