using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] ListMissionsFalas missions;
    [SerializeField] ListMissionsFalas falas;
    [SerializeField] ListMissionsFalas character;
    [SerializeField] Book book;
    [SerializeField] GameObject seta;
    [SerializeField] Player player;

    public int numState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CurrentState()
    {
        switch (numState)
        {
            case 1:
                Mission(0);
                Fala(0);
                Char(0);
                Book(true);
                numState++;
            break;
            case 2:
                seta.SetActive(true);
                Fala(1);
                numState++;
            break;
             
        }
    }

    public void SignalEmitterOne()
    {
        numState = 1;
        CurrentState();

    }

    public void ShowArrow()
    {
        if (numState == 2)
        {
            CurrentState();
        }
    }

    public void ActivePlayer()
    {
        player.Move();
    }

    public void Mission(int mission)
    {
        missions.AddText(mission);
    }

    public void Fala(int fala)
    {
        falas.AddText(fala);
    }

    public void Char(int img)
    {
        character.ShowChar(img);
    }

    public void Book(bool glow)
    {
        book.Glow(glow);
    }
}
