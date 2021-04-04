using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownScript : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void handler(int val)
    {
        if(val == 0)
        {
            output.text = "You chose easy";
        }
        else if(val == 1)
        {
            output.text = "You chose medium";
        }
        else if(val == 2)
        {
            output.text = "You chose hard";
        }
    }
}
