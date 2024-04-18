using System;
using System.Text;
namespace DateTimePrinters{
    class Program{
        static void Main(string[] args){
            DateTime dateTime = DateTime.Now;
            IDateTimePrinter RUPrinter = new RUDateTimePrinter();
            IDateTimePrinter decoratedPrinter = new SymbolDecorator(RUPrinter, " - NedPav");

            Console.WriteLine(decoratedPrinter.PrintDateTime(dateTime));
        }
    }
}