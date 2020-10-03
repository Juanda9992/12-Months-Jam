using UnityEngine;

public class Player : MonoBehaviour
{

    #region PublicStuff
    public float moveSpeed;
    public float smooth;
    public float jumpForce;
    #endregion

    #region PrivateStuff
    private float xMove;
    private Rigidbody2D rb;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {   
        xMove = Input.GetAxis("Horizontal");
        if(xMove > 0)
        {
            rb.velocity = new Vector2(xMove * moveSpeed, rb.velocity.y);
        }
        if(xMove < 0)
        {
            rb.velocity = new Vector2(xMove * moveSpeed, rb.velocity.y);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = transform.up * jumpForce * Time.deltaTime * 10;
        }

    }

    #region Methods
    #endregion
}
