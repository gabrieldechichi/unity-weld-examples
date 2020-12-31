using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

public interface IViewModelCollectionOwner<T>
{
    void SetSelectedItem(T item);
}

[Binding]
public class ViewModel_8_CollectionsAdvanced : ViewModel, IViewModelCollectionOwner<ItemViewModelAdvanced>
{
    ObservableList<ItemViewModelAdvanced> items = new ObservableList<ItemViewModelAdvanced>();

    private string inputText;

    private ItemViewModelAdvanced selectedItem;

    [Binding]
    public ObservableList<ItemViewModelAdvanced> Items { get => items; }

    [Binding]
    public string InputText 
    {
        get => inputText;
        set
        {
            if (inputText != value)
            {
                inputText = value;
                OnPropertyChanged(nameof(InputText));
            }
        }
    }

    private void Awake()
    {
        AddItem("1");
        AddItem("2");
        AddItem("3");
    }

    [Binding]
    public void AddItem()
    {
        if (AddItem(InputText))
        {
            InputText = "";
        }
    }

    [Binding]
    public void RemoveItem()
    {
        if (selectedItem != null && Items.Count > 0)
        {
            Items.Remove(selectedItem);
        }
    }

    private bool AddItem(string displayText)
    {
        if (!string.IsNullOrEmpty(displayText))
        {
            Items.Add(new ItemViewModelAdvanced(this, displayText));
            return true;
        }
        return false;
    }

    public void SetSelectedItem(ItemViewModelAdvanced item)
    {
        if (selectedItem != null)
        {
            selectedItem.IsSelected = false;
        }

        selectedItem = item;
        if (selectedItem != null)
        {
            selectedItem.IsSelected = true;
        }
    }
}
