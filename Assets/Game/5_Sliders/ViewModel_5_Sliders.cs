using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ViewModel_5_Sliders : ViewModel
{
    private float sliderValue = 2.5f;

    private bool isValid = true;

    [SerializeField] private Transform cube = null;

    [Binding]
    public float SliderValue
    {
        get => sliderValue;
        set 
        { 
            if (sliderValue != value) 
            { 
                sliderValue = value; 
                UpdateCubeRotation(); 
                OnPropertyChanged(nameof(SliderValue)); 
            } 
        }
    }

    [Binding]
    public bool IsValid
    {
        get => isValid;
        set { if (isValid != value) { isValid = value; OnPropertyChanged(nameof(IsValid)); } }
    }

    private void Start()
    {
        UpdateCubeRotation();
    }

    private void UpdateCubeRotation()
    {
        cube.rotation = Quaternion.Euler(0f, SliderValue, 0f);
    }
}
