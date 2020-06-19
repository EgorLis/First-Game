using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public GameObject OurCharacter;
    public GameObject MainCamera;
   // private float nextActionTime = 0.0f;
   // public float period = 0.1f;
    // Start is called before the first frame update
    void ChangePosition()
    {
        Vector3 PersonPosition = new Vector3(0, 0);
        PersonPosition = OurCharacter.transform.position;
        if(Input.GetKey(KeyCode.W))
        {
            PersonPosition.y += 0.07f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            PersonPosition.y -= 0.07f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            PersonPosition.x += 0.07f;
        
        }
        else if (Input.GetKey(KeyCode.A))
        {
            PersonPosition.x -= 0.07f;
        }
        OurCharacter.transform.position = PersonPosition;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangePosition();
        Vector3 CameraPosition = new Vector3(0, 0);
        CameraPosition = MainCamera.transform.position;
        CameraPosition.x = OurCharacter.transform.position.x;
        CameraPosition.y = OurCharacter.transform.position.y;
        MainCamera.transform.position = CameraPosition;

    }
}
