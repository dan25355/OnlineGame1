using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float walkspeed = 5f;
    public float runningspeed = 15f;
    public float jumpspeed = 25f;
    public float gravity = 10f;
    public float lookspeed =4f;
    public float lookxlimit = 70f;
    public float health = 100f;
    
    CharacterController characterController;
    Vector3 movevDirection = Vector3.zero;


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Buster")
        {
            Destroy(hit.gameObject);
            Debug.Log("Collision detected with:" + hit.gameObject.name);
            jumpspeed += 10;
        }

        else if (hit.gameObject.tag == "Danger");
        {
            health -= 5f;
            if(health<0)
            {
                Debug.Log("Angus");
                //health = 0;
                //SceneManager.LoadScene(0);
            }
        }









    }

    private void OnControllerColliderHit1(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Debust")
        {
            Destroy(hit.gameObject);
            Debug.Log("Collision detected with:" + hit.gameObject.name);
            runningspeed -= 10;
        }
    }















}
