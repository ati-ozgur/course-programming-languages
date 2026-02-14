public class switch_expressions2_yield {
    public static void main(String[] args) {
	

	int day = 4;
	String message = switch (day) {
	  case 1:
	  case 2:
	  case 3:
	  case 4:
	  case 5:
		System.out.println("before yield");
		yield "Hafta içi";
	  case 6:
	  case 7:
		System.out.println("before yield");
		yield "Hafta sonu";
	  default:
	  	throw new IllegalStateException("Invalid day: " + day);
	}; // gerekli
	System.out.println(message);

    }
}
