# FisJParser

## response.json dosyasının okunabilmesi için dosyayı exe ile aynı dizine taşıyınız ya da program.cs içerisindeki dosya yolunu güncelleyiniz.

## Nasıl çalışır
Projeyi çalıştırdığınızda response.json dosyasını okur ve hazırlanan modellere parse eder. Doldurulan listenin ilk datasını ekrana yazdırır.

## Response.json
```json
[
  {
      "description":"TEŞEKKÜRLER",
      "boundingPoly":{
         "vertices":[
            {
               "x":36,
               "y":88
            },
            {
               "x":174,
               "y":93
            },
            {
               "x":173,
               "y":114
            },
            {
               "x":35,
               "y":109
            }
         ]
      }
   },
   {
      "description":"GUNEYDOĞU",
      "boundingPoly":{
         "vertices":[
            {
               "x":36,
               "y":114
            },
            {
               "x":148,
               "y":116
            },
            {
               "x":148,
               "y":138
            },
            {
               "x":36,
               "y":136
            }
         ]
      }
   }
]
```

## Models

### ReceiptModel (Base Model)
```csharp
public class ReceiptModel
{
  public string locale { get; set; }
  public string description { get; set; }
  public BoundingPoly boundingPoly { get; set; }
}
```

### BoundingPoly
```csharp
public class BoundingPoly
{
  public List<Vertice> vertices { get; set; }
}
```

### Vertice
```csharp
public class Vertice
{
  public int x { get; set; }
  public int y { get; set; }
}
```


