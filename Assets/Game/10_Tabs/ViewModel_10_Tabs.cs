using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ViewModel_10_Tabs : ViewModelMonoBehaviour
{
    private Tab nameTab;
    private Tab addressTab;
    private Tab activeTab;
    
    [Binding]
    public Tab NameTab
    {
        get
        {
            if (nameTab == null)
            {
                nameTab = new NameTab();
            }
            return nameTab;
        }
    }

    [Binding]
    public Tab AddressTab
    {
        get
        {
            if (addressTab == null)
            {
                addressTab = new AddressTab();
            }
            return addressTab;
        }
    }

    [Binding]
    public Tab ActiveTab
    {
        get
        {
            if (activeTab == null)
            {
                activeTab = NameTab;
            }
            return activeTab;
        }
        set
        {
            if (activeTab != value)
            {
                activeTab = value;
                OnPropertyChanged(nameof(ActiveTab));
            }
        }
    }

    [Binding]
    public void ActivateNameTab()
    {
        ActiveTab = NameTab;
    }

    [Binding]
    public void ActivateAddressTab()
    {
        ActiveTab = AddressTab;
    }
}
