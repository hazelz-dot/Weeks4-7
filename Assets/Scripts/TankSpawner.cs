using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
    public GameObject spawnedTank;

    public FirstScript tankScript;
    public SpriteRenderer tankSR; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //instantiate a prefab: make this one appear
            //instantiate a prefab, a vector2 or vector3, a quaternion: make it appear at this position and rotation
            //Instantiate(tankPrefab);
            //Instantiate(tankPrefab, transform.position, transform.rotation);

            //Vector2 spawnPos = Random.insideUnitCircle * 3;
            //quaternion.identity means no rotation which is the same as euler angles (0,0,0)
            //Instantiate(tankPrefab, spawnPos, Quaternion.identity);

            spawnedTank = Instantiate(tankPrefab, transform.position, transform.rotation);

            tankScript = spawnedTank.GetComponent<FirstScript>();

            tankSR = spawnedTank.GetComponent<SpriteRenderer>(); 

            howManyTanks += 1;

            //more tanks, faster speed
            //tankScript.speed = howManyTanks; 
        }

        //if (Mouse.current.rightButton.wasPressedThisFrame == true)
        {
            //instantiate a prefab, a transform: make it appear at 0,0, as the child of that transform
            //Instantiate(tankPrefab, transform);
            //howManyTanks+=1;
        }
    }
}
