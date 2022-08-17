using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorEditingWithSliders : MonoBehaviour
{
    public Slider RedSlider, GreenSlider, BlueSlider;
    public Image image;

    private void Start()
    {
        image.color = new Color(RedSlider.value, GreenSlider.value, BlueSlider.value);

        RedSlider.onValueChanged.AddListener(x => image.color = new Color(x, image.color.g, image.color.b, 1f));
        GreenSlider.onValueChanged.AddListener(x => image.color = new Color(image.color.r, x, image.color.b, 1f));
        BlueSlider.onValueChanged.AddListener(x => image.color = new Color(image.color.r, image.color.g, x, 1f));
    }
}
