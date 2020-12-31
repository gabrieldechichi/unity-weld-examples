using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;


[Adapter(typeof(Exception), typeof(bool))]
public class ExceptionToValidationAdapter : IAdapter
{
    public object Convert(object valueIn, AdapterOptions options)
    {
        return (Exception)valueIn == null;
    }
}
