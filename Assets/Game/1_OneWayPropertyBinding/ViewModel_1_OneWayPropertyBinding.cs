using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

[Binding]
public class ViewModel_1_OneWayPropertyBinding : ViewModel
{
    private string text;

    [Binding]
    public string Text
    {
        get => text;
        set { if (text != value) { text = value; OnPropertyChanged(nameof(Text)); } }
    }

    private void Start()
    {
        StartCoroutine(UpdateText());
    }

    IEnumerator UpdateText()
    {
        var delay = new WaitForSeconds(1.0f);
        var rnd = new System.Random();
        while (true)
        {
            Text = rnd.Next(10000, 20000).ToString();
            yield return delay;
        }
    }
}
