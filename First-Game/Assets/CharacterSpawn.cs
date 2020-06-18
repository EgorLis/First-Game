using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour
{
    public GameObject OurCharacter;
    public GameObject MainCamera;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;
    // Start is called before the first frame update
    void ChangePosition()
    {
        Vector3 PersonPosition = new Vector3(0, 0);
        Vector3 CameraPosition = new Vector3(0, 0);
        PersonPosition = OurCharacter.transform.position;
        PersonPosition.x += 0.2f;
        CameraPosition = MainCamera.transform.position;
        CameraPosition.x += 0.2f;
        OurCharacter.transform.position = PersonPosition;
        MainCamera.transform.position = CameraPosition;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            ChangePosition();
        }
    }
}
