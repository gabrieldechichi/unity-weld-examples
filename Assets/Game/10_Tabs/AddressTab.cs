using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class AddressTab : Tab
{
    private string address;

    [Binding]
    public string Address
    {
        get => address;
        set
        {
            if (address != value)
            {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }
    }
}
