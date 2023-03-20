using System.Net.Http.Headers;

GenerateCountryDataFiles();


void GenerateCountryDataFiles() { 
    Console.WriteLine("wAiT...");
    Console.WriteLine("There u go");
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri($"https://restcountries.com/v3.1/all");
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response = client.GetAsync("").Result;
    if (response.IsSuccessStatusCode) {
        var data = response.Content.ReadAsAsync<IEnumerable<Country>>().Result;
        foreach (var country in data) {
            string fileName = "" + country.Name.Official + ".txt";
            try {
                if (File.Exists(fileName)) File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName)) {
                    sw.WriteLine("Region : " + country.Region + ",  SubRegion : " + country.Subregion + ",  Latlng : " + "[" + country.Latlng[0] + "," + country.Latlng[1] + "]" + ",  Area : " + country.Area + ",  Population : " + country.Population);
                }
            } catch (Exception e) {
                Console.WriteLine(e.ToString);
            }
        }
    } else {
        Console.WriteLine("EUH");
    }
    client.Dispose();
}



public class Country {
    public Name Name { get; set; }
    public String Region { get; set; }
    public String Subregion { get; set; }
    public double[] Latlng { get; set; }
    public double Area { get; set; }
    public int Population { get; set; }

}
public class Name { 
    public String Official { get; set; }
}

