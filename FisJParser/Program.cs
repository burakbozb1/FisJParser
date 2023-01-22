using FisJParser.Models;
using System.Text.Json;

List<ReceiptModel> data = new List<ReceiptModel>();
using (StreamReader r = new StreamReader(@"C:\Users\burak\source\repos\FisJParser\FisJParser\Statics\response.json"))
{
    string json = r.ReadToEnd();
    data = JsonSerializer.Deserialize<List<ReceiptModel>>(json);
}
Console.WriteLine(data[0].description);
Console.ReadLine();