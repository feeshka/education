using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using SpecFlowTests.Common;
using SpecFlowTests.Domain.Organizations;
using SpecFlowTests.Domain.Users;

namespace SpecFlowTests.Domain.Tests.StepDefinitions;

[Binding]
public class OrganizationSteps
{
    private readonly ScenarioContext _scenario;
    private readonly RandomizerTextRegex _stringGenerator;

    public OrganizationSteps(ScenarioContext scenario)
    {
        _scenario = scenario ?? throw new ArgumentNullException(nameof(scenario));
        _stringGenerator = new RandomizerTextRegex(
            new FieldOptionsTextRegex
            {
                Pattern = "[A-Za-z0-9_\\-\\s]{20}",
                UseNullValues = false,
            });
    }

    [Given(@"организация")]
    public void GivenОрганизация()
    {
        _scenario.Set(new Organization(Guid.NewGuid(), new OrganizationName(_stringGenerator.Generate()!)));
    }

    [When(@"я создаю новую организацию с идентификатором (.*)")]
    public void WhenЯСоздаюНовуюОрганизациюСИдентификатором(string id)
    {
        var newOrganizationId = Guid.Parse(id);

        try
        {
            new Organization(newOrganizationId, new OrganizationName(_stringGenerator.Generate()!));
        }
        catch (InvariantValidationException exception)
        {
            _scenario.Set(exception);
        }
    }

    [When(@"я создаю новую организацию с именем из одних лишь пробелов")]
    public void WhenЯСоздаюНовуюОрганизациюСИменемИзОднихЛишьПробелов()
    {
        try
        {
            CreateOrganization("".PadRight(10));
        }
        catch (InvariantValidationException exception)
        {
            _scenario.Set(exception);
        }
    }

    [When(@"я создаю новую организацию без имени")]
    public void WhenЯСоздаюНовуюОрганизациюБезИмени()
    {
        try
        {
            CreateOrganization(string.Empty);
        }
        catch (InvariantValidationException exception)
        {
            _scenario.Set(exception);
        }
    }

    [When(@"я добавляю в организацию нового пользователя")]
    public void WhenЯДобавляюВОрганизациюНовогоПользователя()
    {
        var organization = _scenario.Get<Organization>();
        var newUserId = new UserId(Guid.NewGuid());
        _scenario.Set(newUserId);
        organization.AddUser(newUserId);
    }

    [When(@"я добавляю в организацию нового пользователя дважды")]
    public void WhenЯДобавляюВОрганизациюНовогоПользователяДважды()
    {
        var organization = _scenario.Get<Organization>();
        var newUserId = new UserId(Guid.NewGuid());
        _scenario.Set(newUserId);

        organization.AddUser(newUserId);

        try
        {
            organization.AddUser(newUserId);
        }
        catch (InvariantValidationException exception)
        {
            _scenario.Set(exception);
        }
    }

    [Then(@"такой пользователь есть в организации")]
    public void ThenТакойПользовательЕстьВОрганизации()
    {
        var organization = _scenario.Get<Organization>();
        var expectedUser = _scenario.Get<UserId>();

        organization.Users.Contains(expectedUser);
    }

    private void CreateOrganization(string name)
    {
        new Organization(Guid.NewGuid(), name);

    }
}