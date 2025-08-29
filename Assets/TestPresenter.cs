using R3;

public class TestPresenter
{
    private TestModel model;
    private TestView view;
    
    public TestPresenter(TestModel model,TestView view)
    {
        this.model = model;
        this.view = view;
    }
    
    public void Bind()
    {
        model.num.Subscribe(num => view.SetNum(num))
            .AddTo(view);
        
        view.ButtonClick.Subscribe(_ => model.AddNum(1))
            .AddTo(view);
    }
}
