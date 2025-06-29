using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ArrowClick : MonoBehaviour
{
    [SerializeField] int newScene;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(newScene);
        Debug.Log("foi");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
