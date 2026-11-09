using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 spawnPosition;
    void Start()
    {
        Instantiate(objectToSpawn, spawnPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
