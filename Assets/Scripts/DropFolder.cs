using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropFolder : MonoBehaviour, IDropHandler
{
    [SerializeField] int codigoFolder;
    [SerializeField] PuzzleWin puzzleWin;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            PuzzleCard draggedCard = eventData.pointerDrag.GetComponent<PuzzleCard>();

            if (draggedCard.tipoAnimal == codigoFolder)
            {
                draggedCard.gameObject.SetActive(false);
                puzzleWin.WinVerfication();
            }
            else
            {
                draggedCard.ResetPosition();
            }
        }
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
