using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtrl : MonoBehaviour
{
    public Buttons button;

    //called from ControllableReactor.cs
    public void Pressed()
    {
        switch (button)
        {
            case Buttons.Settings:
                print("Settings");
                break;
            case Buttons.ShowAIHelper:
                print("ShowAIHelper");
                break;
            case Buttons.Tutorial:
                print("Tutorial");
                break;
        }
    }
}

public enum Buttons
{
    ShowAIHelper,
    Settings,
    Tutorial
}
