using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour
{
    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    public bool color = true;

    public void SelectRed()
    {
        if (color == red)
        {
            red.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            color = false;
        }
        else if (color == false)
        {
            red.GetComponent<Renderer>().material.color = new Color(1f, 0, 0);
            color = true;
        }
    }
    public void SelectYellow()
    {
        if (color == yellow)
        {
            yellow.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            color = false;
        }
        else if (color == false)
        {
            yellow.GetComponent<Renderer>().material.color = new Color(1f, 0.9f, 0);
            color = true;
        }
    }
    public void SelectGreen()
    {
        if (color == green)
        {
            green.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
            color = false;
        }
        else if (color == false)
        {
            green.GetComponent<Renderer>().material.color = new Color(0, 1f, 0);
            color = true;
        }
    }
}
