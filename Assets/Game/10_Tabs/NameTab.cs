using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class NameTab : Tab
{
    private string firstName;
    private string lastName;
    
    [Binding]
    public string FirstName
    {
        get => firstName;
        set
        {
            if (firstName != value)
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
    }

    [Binding]
    public string LastName
    {
        get => lastName;
        set
        {
            if (lastName != value)
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
    }
}
