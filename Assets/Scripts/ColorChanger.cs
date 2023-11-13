using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Slider slider;
    public Material color1;
    public Material color2;
    public Material color3;
    public Material color4;
    public Material color5;
    public Material color6;
    public Material color7;
    public Material color8;
    public GameObject cube;
    public float fadeStart = 0;
    public float fadeTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        slider.GetComponent<Slider>();
        //color1.GetComponent<Material>();
        color2.GetComponent<Material>();
        color3.GetComponent<Material>();
        color4.GetComponent<Material>();    
        color5.GetComponent<Material>();
        color6.GetComponent<Material>();
        color7.GetComponent<Material>();
        color8.GetComponent<Material>();
        cube.GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToColor(Material material1, Material materaial2)
    {
        fadeStart += Time.deltaTime * fadeTime;
        material1 = cube.GetComponent<Renderer>().material;
        material1.Lerp(material1, materaial2, fadeStart);
    }

    public void ChangeColor()
    {
        if (slider.value >= 0.00 && slider.value <= 0.09)
        {
            cube.GetComponent<Renderer>().material = color1;
        }
        if (slider.value >= 0.1 && slider.value <= 0.2)
        {
            FadeToColor(color1, color2);
        }
        else if (slider.value >= 0.21 && slider.value <= 0.3)
        {
            FadeToColor(color2, color3);
        }
        else if (slider.value >= 0.31 && slider.value <= 0.4)
        {
            FadeToColor(color3, color4);
        }
        else if (slider.value >= 0.41 && slider.value <= 0.5)
        {
            FadeToColor(color4, color5);
        }
        else if (slider.value >= 0.51 && slider.value <= 0.6)
        {
            FadeToColor(color5, color6);
        }
        else if (slider.value >= 0.71 && slider.value <= 0.8)
        {
            FadeToColor(color6, color7);
        }
        else if (slider.value >= 0.81)
        {
            FadeToColor(color7, color8);
        }
    }
}
