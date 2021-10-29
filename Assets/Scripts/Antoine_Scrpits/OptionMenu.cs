using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public GameObject optionMenuUI;
    public GameObject menuUI;
    public void Option()
    {
        menuUI.SetActive(false);
        optionMenuUI.SetActive(true);
    }

    public void Menu()
    {
        menuUI.SetActive(true);
        optionMenuUI.SetActive(false);
    }
}
