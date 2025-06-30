using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] ListMissionsFalas missions;
    [SerializeField] ListMissionsFalas falas;
    [SerializeField] ListMissionsFalas character;
    [SerializeField] Book book;
    [SerializeField] GameObject seta;
    [SerializeField] GameObject btnMacaco;
    [SerializeField] Player player;

    [SerializeField] PlayableDirector director;
    [SerializeField] PlayableAsset cutscene3;

    public int numState = 0;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "cena2")
        {
            numState = 3;
        }
        if (currentScene.name == "cena1")
        {
            CurrentState();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CurrentState()
    {
        switch (numState)
        {
            case 0:
                Fala(0);
                Char(0);
                numState++;
                break;
            case 1:
                Mission(0);
                Fala(1);             
                Book(true);
                numState++;
            break;
            case 2:
                seta.SetActive(true);
                Fala(2);
                numState++;
            break;
            case 3:
                Fala(3);
                Char(1);
                numState++;
            break;
            case 4:
                Fala(4);
                Char(0);
                Mission(1);
                numState++;
            break;
            case 5:
                Fala(5);
                Char(2);
                director.playableAsset = cutscene3;
                director.Play();
                numState++;
            break;
            case 6:
                Fala(6);
                Char(0);
                numState++;
            break;
            case 7:
                Fala(7);
                Char(3);
                btnMacaco.SetActive(true);
                numState++;
            break;
            case 8:
                Fala(8);
                Char(2);
                Mission(2);
                StartCoroutine(Wait());
            break;
        }
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(4f);
        falas.HideCharandFala();
    }
    public void SignalEmitterOne()
    {
        numState = 1;
        CurrentState();

    }

    public void SignalEmitterNew()
    {
        Debug.Log(numState);
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
