public class Hello {
    public static void Main(String[] args) {
	
		float f = 10.0f;
	    Console.WriteLine(f);
		for (int i=0;i<10 ;i++ ) {
		    f = f / 10;
		    Console.WriteLine(f);
		}
	    Console.WriteLine("");		
		for (int i=0;i<10 ;i++ ) {
		    f = f * 10;			
		    Console.WriteLine(f);
		}

    }
}

