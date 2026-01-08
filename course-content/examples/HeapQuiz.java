public class HeapQuiz {
    int deger = 0;

    public static void main(String[] args) {
        int x = 0;
        HeapQuiz[] dizi = new HeapQuiz[5];
        while (x < 3){
            dizi[x] = new HeapQuiz();
            dizi[x].deger = x;
            x = x + 1;
        }

        dizi[3] = dizi[1];
        dizi[4] = dizi[1];
        dizi[3] = null;
        dizi[4] = dizi[0];
        dizi[0] = null;
        dizi[3] = dizi[2];
        dizi[2] = null;

       for(int i=0;i<dizi.length;i++)
        {
            HeapQuiz a = dizi[i];
            if (a == null)
            {
                System.out.println("NULL");
            }
            else
            {
                System.out.println(a.deger);
            }
        }
    }
}