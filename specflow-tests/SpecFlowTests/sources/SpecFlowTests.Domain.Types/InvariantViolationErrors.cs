namespace SpecFlowTests.Domain.Types;

public static class InvariantViolationErrors
{
    private const string Prefix = "InvariantViolation";

    public static readonly string OrganizationNameCannotBeEmpty = $"{Prefix}:{nameof(OrganizationNameCannotBeEmpty)}";

    public static readonly string EmailCannotBeEmpty = $"{Prefix}:{nameof(EmailCannotBeEmpty)}";

    public static readonly string FirstNameCannotBeEmpty = $"{Prefix}:{nameof(FirstNameCannotBeEmpty)}";

    public static readonly string PhoneNumberCannotBeEmpty = $"{Prefix}:{nameof(PhoneNumberCannotBeEmpty)}";

    public static readonly string EntityIdentifierCannotBeEmpty = $"{Prefix}:{nameof(EntityIdentifierCannotBeEmpty)}";

    public static readonly string UserAlreadyExistsInOrganization = $"{Prefix}:{nameof(UserAlreadyExistsInOrganization)}";

}
