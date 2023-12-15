namespace AddressWebApi.Enums;

/// <summary>
/// Settlement Type (Тип населеного пункту село, місто, і тд)
/// </summary>
public enum SettlementType
{
    /// <summary>
    /// Невідомий
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Місто
    /// </summary>
    City = 1,

    /// <summary>
    /// Cелищe
    /// </summary>
    Towns = 2,

    /// <summary>
    /// Село
    /// </summary>
    Village = 3
}
