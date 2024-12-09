using Reqnroll;

namespace OutputHelperExample.Hooks;

[Binding]
public class TestRunHooks
{
    [BeforeTestRun]
    public static void BeforeTestRun(IReqnrollOutputHelper outputHelper)
    {
        outputHelper.WriteLine("BeforeTestRun");
    }
}