using FisJParser.Models;
using System.Reflection;
using System.Text;
using System.Text.Json;

List<ReceiptModel> data = new List<ReceiptModel>();

using (StreamReader r = new StreamReader(@"response.json"))
{
    string json = r.ReadToEnd();
    data = JsonSerializer.Deserialize<List<ReceiptModel>>(json);
}
Console.WriteLine(data[0].description);
Console.ReadLine();