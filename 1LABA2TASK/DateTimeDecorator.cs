using System;
public abstract class DateTimeDecorator : IDateTimePrinter
{
    protected IDateTimePrinter dateTimePrinter;

    public DateTimeDecorator(IDateTimePrinter dateTimePrinter)
    {
        this.dateTimePrinter = dateTimePrinter;
    }   

    public abstract string PrintDateTime(DateTime dateTime);
}