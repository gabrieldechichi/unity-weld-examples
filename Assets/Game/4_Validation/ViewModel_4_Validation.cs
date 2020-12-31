using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ViewModel_4_Validation : ViewModelMonoBehaviour
{
    private int text;
    
    [Binding]
    public bool Other
    {
        get { return isInputValid; }
        set { isInputValid = value; OnPropertyChanged(nameof(Other)); }
    }

    [Binding]
    public int Input
    {
        get => text;
        set
        {
            if (text != value)
            {
                text = value;
            }
            OnPropertyChanged(nameof(Input));
        }
    }

    private bool isInputValid = true;

    [Binding]
    public bool IsValid
    {
        get => isInputValid;
        set
        {
            if (isInputValid != value)
            {
                isInputValid = value;
                OnPropertyChanged(nameof(IsValid));
            }
        }
    }
}
