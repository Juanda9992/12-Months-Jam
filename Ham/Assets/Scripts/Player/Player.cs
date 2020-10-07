using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    #region PublicStuff
    public float moveSpeed;

    #endregion

    #region PrivateStuff
    private float xMove;
    private Rigidbody2D rb;
    private float timeToWin;
    Transform initialPos;
    bool hasDeath = false;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPos = transform;
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
        if(transform.position.y < -5)
        {
            Death();
        }

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Finish"))    
        {
            timeToWin += Time.deltaTime;
            if(timeToWin > 0.7f)
            {
                SceneLoader scene =GameObject.FindObjectOfType<SceneLoader>();
                scene.LoadScene(scene.levelToLoad);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("pill"))
        {
            SoundManager.PlaySound("Boom");
        }    
    }

    public void Death()
    {
        if(!hasDeath)
        {
            SoundManager.PlaySound("Cry");
            hasDeath = !hasDeath;
        }
        GameObject.FindObjectOfType<SceneLoader>().Restart();
        transform.position = initialPos.position;
    }
    #region Methods
    #endregion
}
