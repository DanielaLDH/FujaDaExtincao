using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class NPC : MonoBehaviour
{
    Manager manager;
    [SerializeField] SpriteRenderer sprite;

    [SerializeField] bool intection;

    [SerializeField] Player player;


    private void OnMouseDown()
    {
        if (intection)
        {
            if (manager.numState == 5)
            {
                StartCoroutine(Wait());
            }
        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        sprite.sortingOrder = Mathf.RoundToInt(-transform.position.y * 100);

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        manager.SignalEmitterNew();
        player.StopImmediately();
    }
}
