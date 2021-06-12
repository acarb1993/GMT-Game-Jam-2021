using UnityEngine;

public class Ladder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Climb climb = collision.GetComponent<Climb>();

        if(climb != null)
        {
            climb.Climbing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Climb climb = collision.GetComponent<Climb>();

        if(climb != null)
        {
            climb.Climbing = false;
        }
    }
}
