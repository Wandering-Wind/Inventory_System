using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    //Setting up an array
    public int[,] shopItems = new int[8, 8];
    public float coins;
    public Text CoinsTxt;

    // Start is called before the first frame update
    void Start()
    {
        //Add ToString to convert float to string
        CoinsTxt.text = "Coins: " + coins.ToString();

        //initialise my array
        //The column 1 will be the IDs
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;
        shopItems[2, 5] = 10;
        shopItems[2, 6] = 10;
        shopItems[2, 7] = 30;

        //Quantity
        //Set the array to 0 because we haven't actually bought any items
        //Next to do after initialising the array is to create a function to buy things
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;


        // Get the button component and add a listener to the click event
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(DuplicatePrefab);
        }
    }

    

    // Update is called once per frame
    void Update()
    {

    }

    public void BuyItems()
    {
        //make a reference to the button and the event system that is already in unity
        //So create a new game object
        //make sure to declare using Unity.EventSystems
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        //Check if we have enough coins to buy items
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonManager>().ItemID])
        {
            //Reduce the coins player has
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonManager>().ItemID];
            //Increase the Quantity
            shopItems[3, ButtonRef.GetComponent<ButtonManager>().ItemID]++;
            //Update our text
            CoinsTxt.text = "Coins: " + coins.ToString();
            //Update the Quanity text on the button itself
            ButtonRef.GetComponent<ButtonManager>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonManager>().ItemID].ToString();

        }

    }


    public GameObject Parent;
    public GameObject imagePotion;
    public GameObject imageCompass;
    public GameObject imageMap;
    public GameObject imageGrimoire;
    public GameObject imageTC;
    public Vector3 Area;
    public Transform TestARea;
    public void SpawnPotion()
    {
        //Image image = this.GetComponent<Image>();
        //GameObject NewSpawnSword = Instantiate(imagePotion, Area, Quaternion.identity);
        //NewSpawnSword.transform.parent = Parent.transform;

        // Instantiate the potionPrefab at the specified spawnPosition with no rotation
            GameObject newPotion = Instantiate(imagePotion, TestARea.position, Quaternion.identity);

            // Set the parent of the new potion to the specified parent
            newPotion.transform.SetParent(Parent.transform);

          // Optionally, reset local position if you want the position to be relative to the parent
            //newPotion.transform.localPosition = Area;
    }
    public void SpawnGrimoire()
    {
        //Image image = this.GetComponent<Image>();
       // GameObject NewSpawnSword = Instantiate(imageGrimoire, Area, Quaternion.identity);
       GameObject NewSpawnSword = Instantiate(imageGrimoire,TestARea.position, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;

    }
    public void SpawnCompass()
    {
        //Image image = this.GetComponent<Image>();
        GameObject NewSpawnCompass = Instantiate(imageCompass, TestARea.position, Quaternion.identity);
        NewSpawnCompass.transform.parent = Parent.transform;
    }
    public void SpawnMap()
    {
        //Image image = this.GetComponent<Image>();
        GameObject NewSpawnSword = Instantiate(imageMap, TestARea.position, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public void SpawnTimecatcher()
    {
        //Image image = this.GetComponent<Image>();
        GameObject NewSpawnSword = Instantiate(imageTC, TestARea.position, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public GameObject prefabToDuplicate; // The prefab to duplicate
    public Transform gridParent; // Parent transform for the grid
    public Vector2 gridSpacing = new Vector2(2, 2); // Spacing between grid elements
    public int columns = 5; // Number of columns in the grid

    

    private int currentIndex = 0; // Index to keep track of the next position in the grid

    public void DuplicatePrefab()
    {
        //This is for the Chest
        // Calculate the position for the new prefab in the grid
        int row = currentIndex / columns;
        int column = currentIndex % columns;
        Vector3 position = new Vector3(column * gridSpacing.x, -row * gridSpacing.y, 0);

        // Instantiate the prefab at the calculated position
        GameObject newPrefab = Instantiate(prefabToDuplicate, position, Quaternion.identity, gridParent);

        // Increment the index for the next position in the grid
        currentIndex++;
    }

    //Public objects for the Backpack
    public GameObject prefabToDuplicateBP; // The prefab to duplicate
    public Transform gridParentBP; // Parent transform for the grid
    public Vector2 gridSpacingBP = new Vector2(2, 2); // Spacing between grid elements
    public int columnsBP = 5; // Number of columns in the grid
    public void DuplicatePrefabBackpack()
    {
        //This is for the Chest
        // Calculate the position for the new prefab in the grid
        int row = currentIndex / columnsBP;
        int column = currentIndex % columnsBP;
        Vector3 position = new Vector3(column * gridSpacingBP.x, -row * gridSpacingBP.y, 0);

        // Instantiate the prefab at the calculated position
        GameObject newPrefab = Instantiate(prefabToDuplicateBP, position, Quaternion.identity, gridParentBP);

        // Increment the index for the next position in the grid
        currentIndex++;
    }

}

//public Transform backpackPanelTransform; // Reference to the transform of the backpack panel
//public void AddItemToBackpack(GameObject item)
//{
//    // Instantiate the item in the backpack panel
//    Instantiate(item, backpackPanelTransform);
//}
//This code was trying to instantiate the whole button in the backpack
//Which obviously gave me a whole bunch of errors



