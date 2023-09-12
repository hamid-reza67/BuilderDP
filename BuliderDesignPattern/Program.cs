

using BuilderDesignPattern;

var request = RequestBuilder.Request("https://localhost:51241")
    .WithHeader("age", "20")
    .WithHeader("Name", "Hamid")
    .AddBodyRequest()
        .WithBody(new
        {
            FirstName = "Hamid",
            LastName = "Shirdel",

        })
        .Build();


var request2 = RequestBuilder.Request("https://localhost:51241")
    .WithHeader("age", "19")
    .WithHeader("Name", "Mohsen")
    .AddFormRequest()
      .WithForm(new { Age = "30" })
      .Build();


Console.WriteLine(request);
Console.WriteLine(request2);


