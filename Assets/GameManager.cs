using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TestView view;
    public TestModel model{ get; private set; }
    public TestPresenter presenter{ get; private set; }
    
    private void Awake()
    {
        model = new TestModel();
        
        presenter = new TestPresenter(model,view);
        
        presenter.Bind();
    }
}
