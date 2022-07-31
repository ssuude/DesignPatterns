public class Singleton
{
    //bu kısmı istediğimiz nesneyi vermek için yazıyoruz.Türü sınıfın türü olacak.---
    private static Singleton instance=null;
    // Nesne olmadan erişilebilmek için static olmalı ,sınıf üzerinden erişebilmek için
    //---

    private string text;
    // Eğer Singleton public olsaydı her yerden erişilebilirdi.
    // Ama private yaptığımızda erişimi engellemiş oluyoruz.
    private Singleton()
    {
        text="Hello World!";
    } 
    //*** Bize haber geldiğinde nesne oluşturulabilecek hale getirmek için.
    
    public static Singleton GetInstance()
    {
        if(instance==null)
            instance=new Singleton();
        //Eğer nesne oluşturulmuş ise if kısmı atlanarak return kısma geçer.
        return instance;
    }
    //***

    public string GetText()
    {
        return text;
    }
}