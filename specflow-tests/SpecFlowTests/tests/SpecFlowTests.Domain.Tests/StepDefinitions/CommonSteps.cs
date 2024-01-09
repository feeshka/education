using SpecFlowTests.Common;

namespace SpecFlowTests.Domain.Tests.StepDefinitions;

[Binding]
public class CommonSteps
{
    private readonly ScenarioContext _scenario;

    public CommonSteps(ScenarioContext scenario)
    {
        _scenario = scenario ?? throw new ArgumentNullException(nameof(scenario));
    }

    [Then(@"я должен получить ошибку проверки инварианта с кодом (.*)")]
    public void ThenЯДолженПолучитьОшибкуПроверкиИнвариантаСКодом(string errorCode)
    {
        var exception = _scenario.Get<InvariantValidationException>();

        exception.ErrorCode.Should().Be(errorCode);
    }
}
