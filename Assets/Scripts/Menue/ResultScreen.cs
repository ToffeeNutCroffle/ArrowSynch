using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultScreen : MonoBehaviour
{
    public Text result;
    public static ResultScreen instance;
    void Start()
    {
        instance=this;
    }

    public void SetResultText()
    {
        result.text="         RESULT\n"+"SCORE : "+GameManager.instance.score+"\nMAX CIMBO : "+GameManager.instance.maxCombo+"\nPERFECT : "+GameManager.instance.perfect+
        "\nGOOD : "+GameManager.instance.good+"\nMISS : "+GameManager.instance.miss;
    }
}
