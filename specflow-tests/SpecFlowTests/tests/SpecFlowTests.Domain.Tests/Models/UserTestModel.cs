using TechTalk.SpecFlow.Assist.Attributes;

namespace SpecFlowTests.Domain.Tests.Models;
public class UserTestModel
{
    public Guid Id { get; set; }

    [TableAliases("Имя")]
    public string Name { get; set; } = string.Empty;

    [TableAliases("Мобильный телефон")]
    public string MobilePhone { get; set; } = string.Empty;

    [TableAliases("Email")]
    public string Email { get; set; } = string.Empty;
}
