using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float stopDistance;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] Transform transformPlayer;

    Animator animator;

    private void Start()
    {
        animator = sprite.GetComponent<Animator>();
    }

    void Update()
    {
        Follow();
    }

    void Follow()
    {
        if (transformPlayer == null) return;

        float distance = Vector2.Distance(transform.position, transformPlayer.position);

        if (distance > stopDistance)
        {
            transform.position = Vector2.MoveTowards(
                transform.position, transformPlayer.position, speed * Time.deltaTime
                );

            if(sprite != null)
            {
                sprite.flipX = transformPlayer.position.x < transform.position.x;
            }

            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
