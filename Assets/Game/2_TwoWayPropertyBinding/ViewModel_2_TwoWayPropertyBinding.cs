using UnityWeld.Binding;

[Binding]
public class ViewModel_2_TwoWayPropertyBinding : ViewModelMonoBehaviour
{
    private string text;

    [Binding]
    public string Text
    {
        get => text;
        set
        {
            if (text != value)
            {
                text = value;
            }
            OnPropertyChanged(nameof(Text));
        }
    }
}
