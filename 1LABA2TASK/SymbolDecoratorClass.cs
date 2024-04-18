using System;
using System.Text;
public class SymbolDecorator : DateTimeDecorator
{

    private string additionalString;

    public SymbolDecorator(IDateTimePrinter dateTimePrinter, string additionalString) : base(dateTimePrinter)
    {
        this.additionalString = additionalString;
    }

    public override string PrintDateTime(DateTime dateTime)
    {
        string printedDateTime = dateTimePrinter.PrintDateTime(dateTime);
        StringBuilder sb = new StringBuilder(printedDateTime);
        sb.Append(additionalString);

        return sb.ToString();
    }
}