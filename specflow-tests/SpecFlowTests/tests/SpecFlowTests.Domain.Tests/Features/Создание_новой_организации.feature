Функциональность: Создание новой организации

    Сценарий: Нельзя создать организацию с пустым идентификатором
        Когда я создаю новую организацию с идентификатором 00000000-0000-0000-0000-000000000000
        Тогда я должен получить ошибку проверки инварианта с кодом InvariantViolation:EntityIdentifierCannotBeEmpty

    Сценарий: Нельзя создать организацию с имененм из одних лишь пробелов
        Когда я создаю новую организацию с именем из одних лишь пробелов
        Тогда я должен получить ошибку проверки инварианта с кодом InvariantViolation:OrganizationNameCannotBeEmpty

    Сценарий: Нельзя создать организацию без имени
        Когда я создаю новую организацию без имени
        Тогда я должен получить ошибку проверки инварианта с кодом InvariantViolation:OrganizationNameCannotBeEmpty
