namespace SpecFlowTests.Domain.Users;

/// <summary>
/// Доменная модель пользователя.
/// </summary>
public class User
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public UserId Id { get; }

    /// <summary>
    /// Имя.
    /// </summary>
    public FirstName Name { get; }

    /// <summary>
    /// Мобильный номер телефона.
    /// </summary>
    public MobilePhoneNumber MobilePhone { get; }

    /// <summary>
    /// Электронная почта.
    /// </summary>
    public Email Email { get; }

    /// <summary>
    /// Инициализирует новый экземпляр доменной модели пользователя.
    /// </summary>
    /// <param name="id">Объект идентификатора пользователя.</param>
    /// <param name="name">Объект имени.</param>
    /// <param name="email">Объект электронного адреса.</param>
    /// <param name="mobilePhoneNumber">Объект мобильного номера телефона.</param>
    public User(UserId id, FirstName name, Email email, MobilePhoneNumber mobilePhoneNumber)
    {
        Id = id;
        MobilePhone = mobilePhoneNumber;
        Email = email;
        Name = name;
    }
}
