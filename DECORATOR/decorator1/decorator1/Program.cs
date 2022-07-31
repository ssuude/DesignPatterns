
interface IComponent
{
    double Operation();
}

class Componet : IComponent
{
    public double paket = 353.53;
    public double kiyafet = 88.34;
    public double binek = 58.87;
    public double silah = 88.34;

    public double Operation()
    {
        double toplam=paket+kiyafet+binek+silah;
        return toplam;
    }
}

class DecaratorA : IComponent
{
    private IComponent component;
    public DecaratorA(IComponent c)
    {
        component = c;
    }
    public double Operation()
    {
        Componet nesne1 = new Componet;
        Console.WriteLine("Ön sipariş fiyati hesaplanıyor.");
        double onsiparis = (nesne1.Operation()) - (nesne1.Operation() * 0.15);
        return onsiparis;
    }
}

class DecaratorB : IComponent
{
    private IComponent component;
    public DecaratorB(IComponent c)
    {
        component = c;
    }
    public double Operation()
    {
        Componet nesne1 = new Componet;
        Console.WriteLine("Ön sipariş fiyati hesaplanıyor.");
        double premiumsiparis = (nesne1.Operation()) - (nesne1.Operation() * 0.15);
        Console.WriteLine("Ek indirim sonucu :");
        return premiumsiparis;
    }
}
class Clinet
{
    static void Uygula(IComponent c)
    {
        Console.WriteLine(c.Operation());
    }
    static void Main()
    {
        Console.WriteLine("normal sipariş:");
        IComponent component = new Component();
        Uygula(component);
        Uygula(new DecaratorA(component));
        Uygula( new DecaratorB(component)); 
    }
}