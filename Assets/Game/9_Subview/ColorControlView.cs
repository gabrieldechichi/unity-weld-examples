using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityWeld.Binding;

[Binding]
public class ColorControlView
{
    private Color color = default;
    private MeshRenderer cube;

    public ColorControlView(MeshRenderer cube)
    {
        this.cube = cube;
        OnColorChanged();
    }

    [Binding]
    public float Red
    {
        get => color.r;
        set
        {
            if (Red != value)
            {
                color.r = value;
                OnColorChanged();
            }
        }
    }

    [Binding]
    public float Green
    {
        get => color.g;
        set
        {
            if (Green != value)
            {
                color.g = value;
                OnColorChanged();
            }
        }
    }

    [Binding]
    public float Blue
    {
        get => color.b;
        set
        {
            if (Blue != value)
            {
                color.b = value;
                OnColorChanged();
            }
        }
    }

    private void OnColorChanged()
    {
        cube.material.color = color;
    }
}
