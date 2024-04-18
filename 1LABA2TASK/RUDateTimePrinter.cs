using System;
public class RUDateTimePrinter : IDateTimePrinter
{
    public string PrintDateTime(DateTime dateTime)
    {
        var cultureInfo = new System.Globalization.CultureInfo("ru-RU");
        return dateTime.ToString("F", cultureInfo);
    }
}