using UnityEngine;

public class PatronSpawn : MonoBehaviour
{
    // Patrons spawn in between these intervals
    [SerializeField] private float spawnTime = 45.0f;
    [SerializeField] private int amountToSpawn = 5;
    [SerializeField] GameObject patron;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (timer % spawnTime == 0)
        {
            Instantiate(patron, transform);
        }

        timer = Time.time;
    }
}
