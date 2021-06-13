using System.Collections;
using UnityEngine;

public class PatronSpawn : MonoBehaviour
{
    // Patrons spawn in between these intervals
    [SerializeField] private float spawnTime = 45.0f;
    [SerializeField] private int amountToSpawn = 5;
    [SerializeField] GameObject patron;
    private float timer;

    void Start()
    {
        timer = spawnTime;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > spawnTime)
        {
            Instantiate(patron, transform);
            timer = 0;
        }
    }

}
