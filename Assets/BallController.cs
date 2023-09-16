using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;
    private Vector3 prevPosition;
    private float sec;
    private float startTime = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isMoving)
            rb.isKinematic = false;

        if (!GameManager.instance.playerWins && !GameManager.instance.isGameOver)
        {
            if (GameManager.instance.isMoving)
            {
                if (rb.velocity == (Vector2)prevPosition)
                {
                    if (startTime == 0)
                        startTime = Time.time;

                    if ((Time.time - startTime) > GameManager.instance.freezedBallTimeout)
                    {
                        GameManager.instance.isGameOver = true;
                        

                    }
                }
            }
        }
    }
}
