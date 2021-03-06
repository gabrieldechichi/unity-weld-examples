﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ViewModel : INotifyPropertyChanged
{
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;    
}
