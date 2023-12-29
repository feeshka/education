using TechTalk.SpecFlow.Assist;

namespace SpecFlowTests.Domain.Tests.Models;

public static class UserTable
{
    public static IReadOnlyCollection<UserTestModel> GetUsers(this Table usersTable) => usersTable.CreateSet<UserTestModel>().ToArray();

    public static UserTestModel GetUser(this Table usersTable) => usersTable.CreateInstance<UserTestModel>();
}