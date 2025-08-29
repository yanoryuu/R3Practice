using R3;
using UnityEngine;
using UnityEngine.UI;

public class TestView : MonoBehaviour
{
    [SerializeField] private Text text;
    
    [SerializeField] private Button button;

    public Button SubButton;
    
    public Subject<Unit> ButtonClick;
    
    private void Awake()
    {
        ButtonClick = new Subject<Unit>();
        
        button.onClick.AddListener(() => ButtonClick.OnNext(Unit.Default));
    }
    public void SetNum(int num)
    {
        text.text = num.ToString();
    }
}
