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

        queueSpot = sq.CreatePosition().transform;
        // Test
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, queueSpot.position, Time.deltaTime * speed);
    }
}
