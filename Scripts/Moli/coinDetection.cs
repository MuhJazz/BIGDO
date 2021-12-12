using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinDetection : MonoBehaviour
{
    public GameObject AHN;
    public GameObject GWW;
    public GameObject FAPERTA;
    public GameObject KOIN;
    public GameObject CCR;
    public GameObject TL;

    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("koin: "+other.name);
        if (other.name == "AHN")
        {
            AHN.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
            AHN.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255/2);
        }
        else if (other.name == "GWW")
        {
            GWW.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
            GWW.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255/2);
        }
        else if (other.name == "FAPERTA")
        {
            FAPERTA.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
            FAPERTA.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255/2);
        }
        else if (other.name == "KOIN")
        {
            KOIN.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
            KOIN.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255/2);
        }
        else if (other.name == "CCR")
        {
            CCR.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
            CCR.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255/2);
        }
        else if (other.name == "TL")
        {
            TL.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
            TL.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255/2);
        }
    }
}
