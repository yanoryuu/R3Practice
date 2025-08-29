using UnityEngine;

public class GameManager : MonoBehaviour
{
    // aaa
    [SerializeField] private TestView view;
    public TestModel model{ get; private set; }
    public TestPresenter presenter{ get; private set; }
    
    public Model model2 { get; private set; }
    
    private void Awake()
    {
        model = new TestModel();
        
        model2 = new Model();
        
        presenter = new TestPresenter(model,view,model2);
        
        presenter.Bind();
    }
}
