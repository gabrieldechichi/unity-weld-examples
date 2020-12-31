﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ItemViewModel
{
    [Binding]
    public string DisplayText
    {
        get;
        private set;
    }

    public ItemViewModel(string displayText)
    {
        this.DisplayText = displayText;
    }
}


[Binding]
public class ViewModel_7_Collections : ViewModel
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
