using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ViewModel_6_Dropdown : ViewModel
{
    private static string[] options = new string[]
    {
        "Option1",
        "Option2",
        "Option3"
    };

    private string selectedItem = options[0];

    [Binding]
    public string[] Options { get => options; }

    [Binding]
    public string SelectedItem
    {
        get => selectedItem;
        set
        {
            if (selectedItem != value)
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
    }
}
