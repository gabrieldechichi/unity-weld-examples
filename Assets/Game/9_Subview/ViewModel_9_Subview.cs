using UnityEngine;
using UnityEngine.Assertions;
using UnityWeld.Binding;

[Binding]
public class ViewModel_9_Subview : ViewModelMonoBehaviour
{
    [SerializeField] private GameObject cube = null;

    private float rotation;

    private ColorControlView colorView = default;

    [Binding]
    public float Rotation
    {
        get => rotation;
        set
        {
            if (rotation != value)
            {
                rotation = value;
                cube.transform.rotation = Quaternion.Euler(0, Rotation, 0);
                OnPropertyChanged(nameof(Rotation));
            }
        }
    }

    [Binding]
    public ColorControlView ColorView 
    { 
        get
        {
            if (colorView == null)
            {
                colorView = new ColorControlView(cube.GetComponent<MeshRenderer>());
            }
            return colorView;
        }
    }

    private void Awake()
    {
        Assert.IsNotNull(cube);
        Assert.IsNotNull(colorView);
        Rotation = 0;
    }
}
