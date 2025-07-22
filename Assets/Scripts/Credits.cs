using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] GameObject credit;


    public void OnClick()
    {
        if (credit.activeSelf)
        {
            credit.SetActive(false);
        }
        else
        {
            credit.SetActive(true);
        }

    }

}
