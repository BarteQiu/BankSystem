using System.Text.Json;

public class BankDataStorage
{
    public void Save(List<bankAccount> bankAccounts)
    {
        string bankdata = JsonSerializer.Serialize(bankAccounts);
        File.WriteAllText("BankDataJson.json", bankdata);
    }

    public List<bankAccount> Load()
    {
        try
        {
            var fileJson = File.ReadAllText("BankDataJson.json");
            List<bankAccount> bankAccounts = JsonSerializer.Deserialize<List<bankAccount>>(fileJson)
                ?? new List<bankAccount>();

            return bankAccounts;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON parsing error: {ex.Message}");
            return new List<bankAccount>();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File reading error: {ex.Message}");
            return new List<bankAccount>();
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"File access error: {ex.Message}");
            return new List<bankAccount>();
        }
    }
}