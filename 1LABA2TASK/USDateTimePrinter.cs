using System;

public class AmericanDateTimePrinter : IDateTimePrinter
{
    public string PrintDateTime(DateTime dateTime)
    {
        var cultureInfo = new System.Globalization.CultureInfo("en-US");
        return dateTime.ToString("F", cultureInfo);
    }
}