using System;
class Program
{
    static void Main(string[] args)
    {
        AllInOnePrinter allInOne = new AllInOnePrinter();
        allInOne.Print("документ");
        allInOne.Scan("фото");
        allInOne.Fax("договор");
        BasicPrinter basic = new BasicPrinter();
        basic.Print("текст");
    }
}
public interface IPrint
{
    void Print(string content);
}
public interface IScan
{
    void Scan(string content);
}
public interface IFax
{
    void Fax(string content);
}
public class AllInOnePrinter : IPrint, IScan, IFax
{
    public void Print(string content)
    {
        Console.WriteLine("printing: " + content);
    }
    public void Scan(string content)
    {
        Console.WriteLine("scanning: " + content);
    }
    public void Fax(string content)
    {
        Console.WriteLine("faxing: " + content);
    }
}
public class BasicPrinter : IPrint
{
    public void Print(string content)
    {
        Console.WriteLine("printing: " + content);
    }
}
public class ScannerPrinter : IPrint, IScan
{
    public void Print(string content)
    {
        Console.WriteLine("printing: " + content);
    }
    public void Scan(string content)
    {
        Console.WriteLine("scanning: " + content);
    }
}