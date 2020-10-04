using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    #region PublicStuff
    public float moveSpeed;
    public float smooth;
    #endregion

    #region PrivateStuff
    private float xMove;
    private Rigidbody2D rb;
    private float timeToWin;
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

    Debug.Log(timeToWin + "");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Finish"))    
        {
            timeToWin += Time.deltaTime;
            if(timeToWin > 1)
            {
                GameObject.FindObjectOfType<SceneLoader>().LoadScene("Scene2");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("pill"))
        {
            PillandPortal portal = other.GetComponent<PillandPortal>();
            portal.togglePortal(); 
        }    
    }
    #region Methods
    #endregion
}
