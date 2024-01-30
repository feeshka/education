using SpecFlowTests.Common;

namespace SpecFlowTests.Domain.Tests.Features.Examples;

[Binding]
public class StepDefinition
{
    [Given(@"организация (.*)")]
    public void GivenОрганизация(string organizationName)
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"в организацию добавлен пользователь:")]
    public void GivenВОрганизациюДобавленПользователь(Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"пользователь успешно добавлен")]
    public void ThenПользовательУспешноДобавлен()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"список пользователей организации (.*):")]
    public void ThenСписокПользователейОрганизации(string organizationName, Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"было отправлено сообщение в telegram:")]
    public void ThenБылоОтправленоСообщениеВTelegram(Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"я добавляю в организацию (.*) нового пользователя:")]
    public void WhenЯДобавляюВОрганизациюНовогоПользователя(string organizationName, Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"я аутентифицирован от имени пользователя (.*) с паролем (.*)")]
    public void GivenЯАутентифицированОтИмениПользователяСПаролем(string userPhone, string password)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"я должен получить ошибку с кодом (.*)")]
    public void ThenЯДолженПолучитьОшибкуСКодом(string errorCode)
    {
        ScenarioContext.StepIsPending();
    }
}
