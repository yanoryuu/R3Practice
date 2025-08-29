using System;
using R3;
using UnityEngine;

public class TestPresenter
{
    private TestModel model;
    private Model model2;
    private TestView view;
    
    private CompositeDisposable disposables;
    
    public TestPresenter(TestModel model,TestView view,Model model2)
    {
        this.model = model;
        this.view = view;
        this.model2 = model2;
        disposables = new CompositeDisposable();
    }
    
    public void Bind()
    {
        /*model.num.Subscribe(num => view.SetNum(num))
            .AddTo(disposables);*/
        
        model.num.Where(num=> num < 10)
            .Subscribe(num => view.SetNum(num))
            .AddTo(disposables);
        
        /*model.num.Where(num => num == 10 )
            .Subscribe(_ => disposables.Dispose())
            .AddTo(disposables);*/
        
        view.ButtonClick.Subscribe(_ => model.AddNum(1))
            .AddTo(disposables);
        
        /*Observable.EveryUpdate()
            .Subscribe(_ =>
            {
                Debug.Log($"Current Num:{model.num.Value}");
            })
            .AddTo(disposables);*/
        
        Observable.Timer(TimeSpan.FromSeconds(20))
            .Subscribe(_ => Debug.Log($"20秒経過"))
            .AddTo(disposables);

        Observable.Interval(TimeSpan.FromSeconds(30))
            .Subscribe(_ => Debug.Log($"30秒経過"))
            .AddTo(disposables);
        
        view.SubButton.OnClickAsObservable()
            .Subscribe(_=>Debug.Log("サブボタンが押された"))
            .AddTo(disposables);
    }
}
