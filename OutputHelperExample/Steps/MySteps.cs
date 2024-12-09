using Reqnroll;

namespace OutputHelperExample.Steps;

[Binding]
public class MySteps
{
    private readonly IReqnrollOutputHelper _outputHelper;

    public MySteps(IReqnrollOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }
    
    [Given("I have entered {int} into the calculator")]
    public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
    {
        _outputHelper.WriteLine($"I have entered {number} into the calculator");
    }
}