using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform PlayerLocation;
    public float speed = .02f;
    public enum Behavior
    private Behavior currentBehavior = Behavior.Passive;


    // Use this for initialization
    void Start ()
    {
		
	}
	
    void MoveToPlayer()
    {
        float newX = transform.position.x;
        float newZ = transform.position.z;
        float newY = transform.position.y;
        Vector3 newPosition;


        if (newX > PlayerLocation.position.x)
        {
            newX -= speed;
        }
        else if (newX < PlayerLocation.position.x)
        {
            newX += speed;
        }

        if (newZ > PlayerLocation.position.z)
        {
            newZ -= speed;
        }
        else if (newZ < PlayerLocation.position.z)
        {
            newZ += speed;
        }

        if (newY > PlayerLocation.position.y+1)
        {
            newY -= speed;
        }
        else if (newY < PlayerLocation.position.y+1)
        {
            newY += speed;
        }

        newPosition = new Vector3(newX, newY, newZ);
        transform.position = newPosition;
        //transform.Rotate()

    }

    void Chillin()
    {


    }

	// Update is called once per frame
	void FixedUpdate ()
    {

        currentBehavior = Behavior.Aggro;

        if(currentBehavior == Behavior.Passive)
        {

        }

        else if (currentBehavior == Behavior.Aggro)
        {
            MoveToPlayer();
        }

        else if (currentBehavior == Behavior.GotEm)
        {

        }



    }
}
