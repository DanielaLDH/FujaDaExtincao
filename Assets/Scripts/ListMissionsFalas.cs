using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListMissionsFalas : MonoBehaviour
{
    [SerializeField] GameObject gameObjectMissions;
    [SerializeField] GameObject gameObjectFala;

    [SerializeField] List<string> missionFalas = new List<string>();
    [SerializeField] List<Sprite> charImages = new List<Sprite>();

    [SerializeField] Text text;
    [SerializeField] Image character;

    // Start is called before the first frame update
    void Start()
    {
 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddText(int num)
    {
        if(gameObjectFala != null)
        {
            gameObjectFala.SetActive(true);
        }
        text.text = missionFalas[num];
    }

    public void ShowChar(int num)
    {

        character.sprite = charImages[num];
    }

    public void HideCharandFala()
    {
        if (gameObjectFala != null)
        {
            gameObjectFala.SetActive(false);
        }
        
    }
}
