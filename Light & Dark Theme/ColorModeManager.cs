using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class ColorModeManager : MonoBehaviour
{
    public bool IsDarkMode { get { return _IsDarkMode; } set { ToggleDarkMode(value); } }
    private bool _IsDarkMode = false;

    private List<ColorMode> colorModes = new List<ColorMode>();

    private void Awake()
    {
        foreach (ColorMode x in Resources.FindObjectsOfTypeAll(typeof(ColorMode)) as ColorMode[])
        {
            colorModes.Add(x);
        }
    }

    private void Start()
    {
        ToggleDarkMode(true);
    }

    public void ToggleDarkMode()
    {
        ToggleDarkMode(!_IsDarkMode);
    }

    public void ToggleDarkMode(bool isDarkMode) 
    {
        _IsDarkMode = isDarkMode;

        colorModes.ForEach(x => x.IsDarkMode = isDarkMode);
    }
}
