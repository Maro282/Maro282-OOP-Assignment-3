

using System.Text.RegularExpressions;

namespace StringValidationExtensions;

public static class StringValidationExtensions
{

    public static bool IsValidEgyptianPhone(this string phone)
    {
        if (string.IsNullOrWhiteSpace(phone)) return false;
        phone = phone.Trim();
        var regex = new Regex(@"^(?:0|\+20)1[0125]\d{8}$");

        return regex.IsMatch(phone);
    }


    public static bool IsValidEgyptianNationalId(this string id)
    {
        if (string.IsNullOrWhiteSpace(id)) return false;
        id = id.Trim();
        var regex = new Regex(@"^[23]\d{13}$");

        return regex.IsMatch(id);
    }
}
