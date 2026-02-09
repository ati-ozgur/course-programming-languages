public class switch_expressions1 {
    public static void main(String[] args) {
	
	int day = 4;
	String message = switch (day) {
	  case 1  -> "Pazartesi";
	  case 2  -> "Salı";
	  case 3  -> "Çarşamba";
	  case 4  -> "Perşembe";
	  case 5  -> "Cuma";
	  case 6  -> "Cumartesi";
	  case 7  -> "Pazar";
	  default -> throw new IllegalStateException("Invalid day: " + day);
	}; // gerekli
	System.out.println(message);

    }
}

