using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraMovement cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (tag == "Door")
            {
                if (collision.transform.position.x < transform.position.x)
                    cam.MoveToNewRoom(nextRoom);
                else
                    cam.MoveToNewRoom(previousRoom);
            }
            else if (tag == "Floor")
            {
                if (collision.transform.position.y < transform.position.y)
                    cam.MoveToNewRoom(nextRoom);
                else
                    cam.MoveToNewRoom(previousRoom);
            }
            
        }
    }
    }
