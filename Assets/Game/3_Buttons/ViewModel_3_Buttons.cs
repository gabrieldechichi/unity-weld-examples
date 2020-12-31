using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ViewModel_3_Buttons : ViewModelMonoBehaviour
{
    [SerializeField] Transform cube = default;
    [SerializeField] float rotation = 90;

    [Binding]
    public void RotateCube()
    {
        cube.Rotate(cube.up, rotation);
    }
}
