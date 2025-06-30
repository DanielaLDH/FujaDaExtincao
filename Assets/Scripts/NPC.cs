using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class NPC : MonoBehaviour
{
    Manager manager;
    [SerializeField] SpriteRenderer sprite;

    [SerializeField] bool intection;


    private void OnMouseDown()
    {
        if (intection)
        {
            if (manager.numState == 5)
            {
                manager.SignalEmitterNew();
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
}
