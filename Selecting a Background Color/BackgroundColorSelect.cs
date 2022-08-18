using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundColorSelect : MonoBehaviour
{
    public Image Background;

    public Transform ContentParent;
    public GameObject ColorSelectButtonTemplate;

    public List<Color32> Colors;

    private void Start()
    {
        ColorSelectButtonTemplate.SetActive(false);

        ClearContent();
        AddColors();
    }

    public void ClearContent() 
    {
        foreach (Transform x in ContentParent)
            if(x.gameObject != ColorSelectButtonTemplate)
                Destroy(x.gameObject);
    }

    private void AddColors() 
    {
        foreach (Color32 x in Colors) 
        {
            GameObject y = Instantiate(ColorSelectButtonTemplate, ContentParent);
            y.SetActive(true);
            y.GetComponent<Image>().color = x;
            y.GetComponent<Button>().onClick.RemoveAllListeners();
            y.GetComponent<Button>().onClick.AddListener(() => SetBackgroundColor(x));
        }
    }

    public void SetBackgroundColor(Color32 color)
    {
        Background.color = color;
    }
}
