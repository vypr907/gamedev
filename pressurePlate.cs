using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pressureSwitch : MonoBehaviour
{
    public GameObject door; //refernce to the door game object
    private bool onPlate; //flag to check if the player is on the pressure plate


    private void OnTriggerEnter(Collider other)
    {
        if(other.Compare.tag("Player"))  //check if the collider belongs to the player
        { 
            onPlate = true; //set the flag to true when the player enters the pressure plate
            OpenDoor(); //call the open door function
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            onPlate = false;
            CloseDoor();
        }
    }

    private void OpenDoor()
    {
        door.SetActive(true); //activate the game object to open the door
    }

    private void CloseDoor()
    {
        door.SetActive(false); //deactivate the door game object to close the door
    }
}

//Assign this script to the pressure plate game object and assign the door game object to the "door" variable in Unity