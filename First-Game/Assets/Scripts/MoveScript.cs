using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public SpriteRenderer PersonSprite;
    public GameObject OurCharacter;
    public GameObject MainCamera;
    private bool isCrouch = false;
    private float MoveCoeffi = 0.07f;
    
   // private float nextActionTime = 0.0f;
   // public float period = 0.1f;
    // Start is called before the first frame update
    public void CrouchControl()
    {
        if (Input.GetKey(KeyCode.R))
        {
            MoveCoeffi = 0.02f;
        }

        if(Input.GetKey(KeyCode.T))
        {
            MoveCoeffi = 0.07f;
        }

    }
   // private float nextActionTime = 0.0f;
   // public float period = 0.1f;
    // Start is called before the first frame update
    void ChangePosition()
    {
        Vector3 PersonPosition = new Vector3(0, 0);
        PersonPosition = OurCharacter.transform.position;
        if(Input.GetKey(KeyCode.W))
        {
            PersonPosition.y += MoveCoeffi;

        }
        else if(Input.GetKey(KeyCode.S))
        {
            PersonPosition.y -= MoveCoeffi;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            PersonPosition.x += MoveCoeffi;
            if (PersonSprite.flipX)
            {

            }
            else
            {
                PersonSprite.flipX = true;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            PersonPosition.x -= MoveCoeffi;
            if (!PersonSprite.flipX)
            {

            }
            else
            {
                PersonSprite.flipX = false;
            }
        }
       
        OurCharacter.transform.position = PersonPosition;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OurCharacter==null)
        {
        }
        else
        {
            CrouchControl();
            ChangePosition();
            Vector3 CameraPosition = new Vector3(0, 0);
            CameraPosition = MainCamera.transform.position;
            CameraPosition.x = OurCharacter.transform.position.x;
            CameraPosition.y = OurCharacter.transform.position.y;
            MainCamera.transform.position = CameraPosition;
        }
    }
}
