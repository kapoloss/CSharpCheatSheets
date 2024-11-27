namespace Others;

public class GenericMethods
{
    //Bir sınıfın kendisi generic olmasa bile, içinde generic metotlar tanımlanabilir.
}

public static class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}