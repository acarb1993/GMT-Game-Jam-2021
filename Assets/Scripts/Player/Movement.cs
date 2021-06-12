using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Vector2 input;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Left and right movement only.
        input = new Vector2(Input.GetAxis("Horizontal"), 0);
    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + input * Time.fixedDeltaTime * speed);
        Debug.Log(speed);
    }
}
