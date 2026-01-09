

Document doc1 = new Document();
doc1.text = "Dokuman 1";
var yeniDoc = doc1;

yeniDoc.text = "Alo Aloo";

Console.WriteLine(doc1.text); // prints "Alo Aloo"
Console.WriteLine(yeniDoc.text); // prints "Alo Aloo"

class Document {
  public string text;
}
