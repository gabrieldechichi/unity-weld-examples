using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ItemViewModel : INotifyPropertyChanged
{
    private string displayText;

    [Binding]
    public string DisplayText
    {
        get => displayText;
        private set
        {
            if (displayText != value)
            {
                displayText = value;
                OnPropertyChanged(nameof(displayText));
            }
        }
    }

    public ItemViewModel(string displayText)
    {
        this.DisplayText = displayText;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


[Binding]
public class ViewModel_7_Collections : ViewModelMonoBehaviour
{

    ObservableList<ItemViewModel> items = new ObservableList<ItemViewModel>()
    {
        new ItemViewModel("1"),
        new ItemViewModel("2"),
        new ItemViewModel("3"),
    };

    [Binding]
    public ObservableList<ItemViewModel> Items { get => items; }

    [Binding]
    public void AddItem()
    {
        Items.Add(new ItemViewModel((Items.Count + 1).ToString()));
    }

    [Binding]
    public void RemoveItem()
    {
        if (Items.Count > 0)
        {
            Items.RemoveAt(Items.Count - 1);
        }
    }
}
