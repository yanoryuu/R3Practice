using R3;
using UnityEngine;
using UnityEngine.UI;

public class TestView : MonoBehaviour
{
    [SerializeField] private Text text;
    
    [SerializeField] private Button button;
    public Subject<Unit> onClick;
    
    private void Awake()
    {
        onClick = new Subject<Unit>();
        button.onClick.AddListener(() => onClick.OnNext(Unit.Default));
    }
    public void SetNum(int num)
    {
        text.text = num.ToString();
    }
}
