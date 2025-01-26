using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorManager : MonoBehaviour
{
    public static ButtonColorManager instance;
    public Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        instance=this;
    }

    public void SetColorDark(int unchange)
    {
        for(int i=0; i<buttons.Length; i++)
        {
            if(i != unchange)
            {
                buttons[i].GetComponent<Image>().color=new Color(0.4f,0.4f,0.4f);
            }
        }
        buttons[buttons.Length-1].interactable=false;
    }

    public void SetColorBright()
    {
        for(int i=0; i<buttons.Length; i++)
        {
            buttons[i].GetComponent<Image>().color=new Color(1,1,1);
        }
        buttons[buttons.Length-1].interactable=true;
    }
    
}
