using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public TMP_Text displayedText;
    public TMP_Text playButtonText;
    void Start()
    {
        if (GameManager.firstRun)
        {
            displayedText.text = "Félicitations pour votre victoire !\r\nVous pouvez désormais partir à la conquête de ce monde.";
            playButtonText.text = "Rejouer";
        }
    }
}
