using UnityEngine;

public class TimeSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
    public GameObject spawnedTank;

    public FirstScript tankScript;
    public SpriteRenderer tankSR;
    

    public void spawn()
    {
        spawnedTank = Instantiate(tankPrefab, transform.position, transform.rotation);

        tankScript = spawnedTank.GetComponent<FirstScript>();

        tankSR = spawnedTank.GetComponent<SpriteRenderer>();

        howManyTanks += 1;
    }
}
