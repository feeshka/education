using SpecFlowTests.Common;
using SpecFlowTests.Domain.Types;
using SpecFlowTests.Domain.Users;

namespace SpecFlowTests.Domain.Organizations;

/// <summary>
/// Доменная модель организации.
/// </summary>
public sealed class Organization : AggregateRoot<Organization.StateData>
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public OrganizationId Id => State.Id;

    /// <summary>
    /// Наименование.
    /// </summary>
    public OrganizationName Name => State.Name;

    /// <summary>
    /// Список пользователей этой организации.
    /// </summary>
    public IReadOnlyCollection<UserId> Users => State.Employees.Select(userId => new UserId(userId)).ToList();

    /// <summary>
    /// Инициализирует новый экземпляр доменной модели организации.
    /// </summary>
    /// <param name="id">Объект идентификатора.</param>
    /// <param name="organizationName">Объект имени организации.</param>
    public Organization(OrganizationId id, OrganizationName organizationName)
    {
        State.Id = id;
        State.Name = organizationName;
    }

    /// <summary>
    /// Добавляет нового пользователя в список сотрудников организации.
    /// </summary>
    /// <param name="newUser">Сотрудник, которого необходимо добавить в организацию.</param>
    /// <exception cref="InvariantValidationException">Нарушено одно из бизнес правил.</exception>
    public void AddUser(UserId newUser)
    {
        if (Users.Contains(newUser))
        {
            throw new InvariantValidationException(InvariantViolationErrors.UserAlreadyExistsInOrganization);
        }

        State.Employees.Add(newUser);
    }

    /// <summary>
    /// Хранимое состояние доменной модели организации.
    /// </summary>
    public sealed class StateData
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// список сотрудников организации.
        /// </summary>
        public IList<Guid> Employees { get; set; } = new List<Guid>();
    }
}
