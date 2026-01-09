public class Program
{
    int Deger = 5;
    public static void Main()
    {
        Program[] dizi = new Program[5];
        for(int i=0;i<=2;i++)
        {
            dizi[i] = new Program();
            dizi[i].Deger = i;
        }

        dizi[3] = dizi[1];
        dizi[2] = dizi[3];
        dizi[1] = dizi[0];

    
        for(int i=0;i<dizi.Length;i++)
        {
            Program a = dizi[i];
            if (a == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(a.Deger);
            }
        }
        
    }
}
