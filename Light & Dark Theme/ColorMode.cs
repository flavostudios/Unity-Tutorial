using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorMode : MonoBehaviour
{
    public Sprite darkModeSprite, lightModeSprite;
    public Color32 darkModeImageColor, lightModeImageColor;
    
    [Space, Space]
    public string darkModeText;
    public string lightModeText;
    public Color32 darkModeTextColor, lightModeTextColor;

    public bool IsDarkMode { set { ToggleDarkMode(value); } }

    private void ToggleDarkMode(bool isDarkMode)
    {
        if (GetComponent<Image>() != null)
        {
            if (darkModeSprite != null && lightModeSprite != null)
                GetComponent<Image>().sprite = isDarkMode ? darkModeSprite : lightModeSprite;

            GetComponent<Image>().color = isDarkMode ? darkModeImageColor : lightModeImageColor;
        }

        if (GetComponent<Text>() != null)
        {
            if (darkModeText != null && lightModeText != null)
                GetComponent<Text>().text = isDarkMode ? darkModeText : lightModeText;

            GetComponent<Text>().color = isDarkMode ? darkModeTextColor : lightModeTextColor;
        }
    }
}
