using UnityEngine;

public class QueuePosition : MonoBehaviour
{
    public bool Taken { get; set; }
    public Transform Next { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Taken = false;
        Next = null;
    }

}
