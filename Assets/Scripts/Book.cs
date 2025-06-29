using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    [SerializeField] Sprite bookGlow;
    [SerializeField] Sprite bookNoGlow;
    [SerializeField] GameObject bookMission;

    [SerializeField] Manager manager;

    Player player;
    int state;

    Image book;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        book = GetComponent<Image>();
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Glow(bool glow)
    {
        if (glow)
        {
            book.sprite = bookGlow;
        }
        else
        {
            book.sprite = bookNoGlow;
        }
    }

    public void OnClick()
    {
        if (bookMission.activeSelf)
        {
            manager.ShowArrow();
            bookMission.SetActive(false);         
        }
        else
        {
            bookMission.SetActive(true);
            Glow(false);
        }
        player.Move();

    }

}
