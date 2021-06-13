using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private Transform items;
    private float xMove, yMove;
    private Rigidbody2D rb2d;
    private Climb climb;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        climb = GetComponent<Climb>();
    }

    void Update()
    {
        // Left and right movement only.
        xMove = Input.GetAxis("Horizontal");
        yMove = 0;

        // Have the player face the direction they're moving towards
        if (xMove > 0)
            items.transform.localScale = Vector3.one;
        else if (xMove < 0)
            items.transform.localScale = new Vector3(-1, 1, 1);

        if(climb.Climbing)
        {
            yMove = Input.GetAxis("Vertical");
        }
    }

    void FixedUpdate()
    {
        Vector2 input = new Vector2(xMove, yMove);
        rb2d.MovePosition(rb2d.position + input * Time.fixedDeltaTime * speed);
    }
}
