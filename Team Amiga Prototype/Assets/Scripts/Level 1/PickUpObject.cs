using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    /*Public GameObjects*/
    //////////////////////
    public GameObject PlayerHands; 
    public GameObject Object;
    public GameObject Player;
    public GameObject Table;
    //////////////////////

    /*Booleans / Flags*/
    ////////////////////
    bool CanPickUp = false;
    bool HasItem = false;
    bool TableBool = false;
    ////////////////////

    void Update()
    {
        PickUp();
        Place();
    }

    /*Allows the Player to pickup the desired object*/
    //////////////////////////////////////////////////
    public void PickUp()
    {
        if (Input.GetKey("e") && CanPickUp == true)
        {
            /*Player.GetComponent<Rigidbody>().isKinematic = true;*/
            Object.GetComponent<Rigidbody>().isKinematic = true;

            Object.transform.SetPositionAndRotation(PlayerHands.transform.position, PlayerHands.transform.rotation);
            Object.transform.parent = PlayerHands.transform;

            HasItem = true;
        }
    }
    //////////////////////////////////////////////////
    
    /*Allows the Player to place the desired object*/
    /////////////////////////////////////////////////
    public void Place()
    {
        if (Input.GetKey("q") && HasItem == true && TableBool == true) 
        {
            /*Player.GetComponent<Rigidbody>().isKinematic = false;*/
            /*Object.GetComponent<Rigidbody>().isKinematic = false;*/ 
            
            Object.transform.SetPositionAndRotation(Table.transform.position + new Vector3 (0,1,0), Table.transform.rotation); 
            Object.transform.parent = Table.transform.parent;

            HasItem = false;
        }
    }
    /////////////////////////////////////////////////

    /*Detects when the Player is in collision */
    ////////////////////////////////////////////
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            CanPickUp = true;  
        }

        if (other.CompareTag("Table"))
        {
            TableBool = true;
        }
    }
    ////////////////////////////////////////////

    /*Detects when the Player is out of collision */
    ////////////////////////////////////////////////
    private void OnTriggerExit(Collider other)
    {
        CanPickUp = false; 
        TableBool = false;
    }
    ////////////////////////////////////////////////
}
