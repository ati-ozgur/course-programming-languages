

Document doc1 = new Document();
doc1.text = "Dokuman 1";
var yeniDoc = doc1;

yeniDoc.text = "Alo Aloo";

Console.WriteLine(doc1.text); // prints "Dokuman 1"
Console.WriteLine(yeniDoc.text); // prints "Alo Aloo"

struct Document {
  public string text;
}
