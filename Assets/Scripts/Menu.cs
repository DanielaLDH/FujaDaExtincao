using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject fadeout;


    public void OnPlay()
    {
        Time.timeScale = 1f;
        StartCoroutine(Fade());

    }

    IEnumerator Fade()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(1f); // tempo da anima��o de fade
        SceneManager.LoadScene(1);

    }

}
