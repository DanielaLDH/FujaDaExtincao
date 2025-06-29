using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 targetPosition;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Animator animator;

    bool canClick = true;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }

    void OnClick()
    {
        if (canClick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            }
            animator.SetBool("isWalking", true);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
            if (targetPosition.x < transform.position.x)
            {
                sprite.flipX = true;
            }
            if (targetPosition.x >= transform.position.x)
            {
                sprite.flipX = false;
            }
            if(targetPosition.x ==  transform.position.x && targetPosition.y == transform.position.y)
            {
                animator.SetBool("isWalking", false);

            }
        }

    }

    public void Move()
    {
        if (canClick)
        {
            canClick = false;
        }
        else
        {
            canClick = true;
        }
    }
}
