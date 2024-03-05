using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int[] inventory;
    //public ArrayList inventory;
    //public int inventorySize;
    private int numPossibleItems;
    public string[] Names;
    
    // Start is called before the first frame update
    void Start()
    {
        //inventory = new int[inventorySize];
        numPossibleItems = Names.Length;
        inventory = new int[numPossibleItems];
        //inventory = new ArrayList(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //adds item given ID (ID uses 0 based index)
    public void addItem(int itemID)
    {
        inventory[itemID]++;
    }

    //removes item given ID (ID uses 0 based index)
    public void removeItem(int itemID)
    {
        if(inventory[itemID] > 0) {
            inventory[itemID]--;
        }
         else {
            //display out of stock message
        }
    }

    //gets item name given ID (ID uses 0 based index)
    public string getItemName(int itemID) {
        if(itemID > 0 && itemID < numPossibleItems) {
            return Names[itemID];
        }
         else {
            //no item with this ID
        }
        return "ERROR";
    }
}
