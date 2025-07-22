using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ArrowClick : MonoBehaviour
{
    [SerializeField] int newScene;
    [SerializeField] GameObject fadeout;

    public void OnMouseDown()
    {
        StartCoroutine(Wait());

        SceneManager.LoadScene(newScene);
    }

    IEnumerator Wait()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(2f);
    }


}
