using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public KeyCode pickupKey;
    public GameObject playerRange;
    private bool keyDown;
    public int itemID;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pickupKey)) {
            keyDown = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (keyDown) {
            if(col.gameObject == playerRange) {
                PickUpItem();
                // Delete the object
                Destroy(gameObject);
            }
            keyDown = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        //hide UI that item can be picked up
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //show UI that item can be picked up
    }

    void PickUpItem()
    {
        //DISPLAY MESSAGE
        playerRange.transform.parent.gameObject.GetComponent<PlayerInventory>().addItem(itemID);
    }
}
