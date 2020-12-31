using UnityWeld.Binding;

[Binding]
public class ItemViewModelAdvanced : ItemViewModel
{
    private IViewModelCollectionOwner<ItemViewModelAdvanced> owner;

    private bool isSelected = false;

    [Binding]
    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }

    public ItemViewModelAdvanced(IViewModelCollectionOwner<ItemViewModelAdvanced> owner,  string displayText) : base(displayText)
    {
        this.owner = owner;
    }

    [Binding]
    public void OnSelect()
    {
        if (owner != null)
        {
            owner.SetSelectedItem(this);
        }
    }
}
