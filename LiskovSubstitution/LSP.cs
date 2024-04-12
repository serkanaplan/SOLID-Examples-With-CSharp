namespace SOLID.LSP;

public interface ITakePhoto
{
    void TakePhoto();
}


public abstract class BasePhone
{
    public void Call() => Console.WriteLine("Araya yapıldı");
}

public class IPhone : BasePhone, ITakePhoto
{
    public void TakePhoto() => Console.WriteLine("Fotoğraf çekildi");
}


public class Nokia3310 : BasePhone
{

}