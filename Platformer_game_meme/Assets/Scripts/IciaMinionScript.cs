using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IciaMinionScript : MonoBehaviour
{
    public int MinionSpeed;
    public int XMoveDirection;
    public int hp = 10;
    public GameObject Health;
    public bool facingRight = true;
    public int Minionhp1 = 50;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * MinionSpeed;
        if (hit.distance < 0.7f)
        {
            if (hit.collider.tag == "enemy" && hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
            }
            else if (hit.collider.tag == "boss" && hit.collider != null)
            {
                Destroy(gameObject);
            }
            else
            {
                Flip();
                FlipEnemy();
            }
        }
    }
    void Flip()
    {
        if (XMoveDirection > 0)
        {
            XMoveDirection = -1;
        }
        else
        {
            XMoveDirection = 1;
        }
    }

    void FlipEnemy()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
