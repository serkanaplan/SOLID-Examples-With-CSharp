
namespace SOLID.NotLSP;
public abstract class BasePhone
{
    public void Call() => Console.WriteLine("Araya yapıldı");
    public abstract void TakePhoto();
}

public class IPhone : BasePhone
{
    public override void TakePhoto() => Console.WriteLine("Fotoğraf çekildi");
}


public class Nokia3310 : BasePhone
{
    public override void TakePhoto() => throw new NotImplementedException();
}