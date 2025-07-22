using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOpen : MonoBehaviour
{
    [SerializeField] GameObject puzzle;

    private void OnMouseDown()
    {
        puzzle.SetActive(true);
    }


}
