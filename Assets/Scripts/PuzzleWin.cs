using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleWin : MonoBehaviour
{
    int cartasCertas=0;
    [SerializeField] GameObject puzzle;


    public void WinVerfication()
    {
        cartasCertas++;
        if (cartasCertas == 6)
        {
            puzzle.SetActive(false);
        }
    }
}
