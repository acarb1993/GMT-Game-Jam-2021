using UnityEngine;

public class PatronMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    private GameObject shopQueue;
    private Transform queueSpot;
    
    void Start()
    {
        shopQueue = GameObject.Find("Shop Queue");
        ShopQueue sq = shopQueue.GetComponent<ShopQueue>();

        // TODO only make a new spot if all the available ones are taken.
        // Also make it so the patrons move up in line if there's time
        queueSpot = sq.CreatePosition().transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, queueSpot.position, Time.deltaTime * speed);
    }
}
