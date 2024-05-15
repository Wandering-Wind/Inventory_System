using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    [TextArea] public string itemDescription;
    public int itemPrice;
    // Start is called before the first frame update
    void Start()
    {
       // This is used for non-instanced items 
       //Therefore, I think I need instanced objects so that I can 
       // add in unique attributes such as condition or random statistics
       //Do I actually need instanced objects?
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
