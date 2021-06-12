using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
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

        if (climb.Climbing)
        {
            yMove = Input.GetAxis("Vertical");
        }
    }

    void FixedUpdate()
    {
        Vector2 input = new Vector2(xMove, yMove);
        rb2d.MovePosition(rb2d.position + input * Time.fixedDeltaTime * speed);
        Debug.Log(speed);
    }
}
