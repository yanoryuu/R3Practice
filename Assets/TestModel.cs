using R3;

public class TestModel
{
    public ReactiveProperty<int> num{ get; private set; }
    public TestModel()
    {
        num = new ReactiveProperty<int>(0);
    }
    
    public void AddNum(int value)
    {
        num.Value += value;
    }
}
