// Allows a sprite to climb ladders
using UnityEngine;

public class Climb : MonoBehaviour
{
    public bool Climbing { get; set; }

    void Start()
    {
        Climbing = false;
    }
}
