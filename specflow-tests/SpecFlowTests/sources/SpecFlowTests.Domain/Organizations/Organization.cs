using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;
using SpecFlowTests.Domain.Users;
using System.Linq;

namespace SpecFlowTests.Domain.Organizations;

/// <summary>
/// Доменная модель организации.
/// </summary>
public class Organization
{
    private List<UserId> _users { get; } = new List<UserId>();

    /// <summary>
    /// Идентификатор.
    /// </summary>
    public OrganizationId Id { get; }

    /// <summary>
    /// Наименование.
    /// </summary>
    public OrganizationName Name { get; }

    /// <summary>
    /// Список пользователей этой организации.
    /// </summary>
    public IReadOnlyCollection<UserId> Users => _users;

    /// <summary>
    /// Инициализирует новый экземпляр доменной модели организации.
    /// </summary>
    /// <param name="id">Объект идентификатора.</param>
    /// <param name="organizationName">Объект имени организации.</param>
    public Organization(OrganizationId id, OrganizationName organizationName)
    {
        Id = id;
        Name = organizationName;
    }

    /// <summary>
    /// Добавляет нового пользователя в список пользователей организации.
    /// </summary>
    /// <param name="newUser">Пользователь, которого необходимо добавить в организацию.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public void AddUser(UserId newUser)
    {
        if (Users.Contains(newUser))
        {
            throw new InvariantValidationException(InvariantViolationErrors.UserAlreadyExistsInOrganization);
        }

        _users.Add(newUser);
    }
}
