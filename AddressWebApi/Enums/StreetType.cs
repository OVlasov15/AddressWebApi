namespace AddressWebApi.Enums;

/// <summary>
/// Street Type (Тип ваулиці)
/// </summary>
public enum StreetType
{
    /// <summary>
    /// Невідомий
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// Street (Вулиця)
    /// </summary>
    Street = 1,

    /// <summary>
    /// Prospect (Проспект) 
    /// </summary>
    Prospect = 2,

    /// <summary>
    /// Prospect (Набережна) 
    /// </summary>
    Naberezhna = 3,

    /// <summary>
    /// Prospect (Бульвар) 
    /// </summary>
    Boulevard = 4,

    /// <summary>
    /// Lane (Провулок) 
    /// </summary>
    Lane = 5,

    /// <summary>
    /// Tupyk (Тупик) 
    /// </summary>
    Tupyk = 6,

    /// <summary>
    /// Uzviz (Узвіз) 
    /// </summary>
    Uzviz = 7
}
