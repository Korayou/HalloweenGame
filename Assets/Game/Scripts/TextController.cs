using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TextMeshPro displayedText;
    public TextMeshPro playButtonText;
    void Start()
    {
        if (!GameManager.firstRun)
        {
            displayedText.text = "F�licitations pour votre victoire !\r\nVous pouvez d�sormais partir � la conqu�te de ce monde.";
            playButtonText.text = "Rejouer";
        }
    }
}
