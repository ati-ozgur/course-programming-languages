public class switch_expressions1 {
    public static void Main(string[] args) {
        
        int day = 4;
        string message = day switch {
            1 => "Pazartesi",
            2 => "Salı",
            3 => "Çarşamba",
            4 => "Perşembe",
            5 => "Cuma",
            6 => "Cumartesi",
            7 => "Pazar",
            _ => throw new ArgumentException($"Invalid day: {day}")
        };
        Console.WriteLine(message);
    }
}