using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropFolder : MonoBehaviour, IDropHandler
{
    [SerializeField] int codigoFolder;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            PuzzleCard draggedCard = eventData.pointerDrag.GetComponent<PuzzleCard>();

            if (draggedCard.tipoAnimal == codigoFolder)
            {
                draggedCard.gameObject.SetActive(false);
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
