using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    private GameObject shopEntrance;
    
    void Start()
    {
        shopEntrance = GameObject.Find("Shop Entrance");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, shopEntrance.transform.position, Time.deltaTime * speed);
    }
}
