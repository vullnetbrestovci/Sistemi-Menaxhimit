public class Student : Person
{
    public int IdStudenti { get; set; }
    public string Drejtimi { get; set; }

    public override void ShfaqInformacion()
    {
        Console.WriteLine($"Student: {Emri}\n  Mosha: {Mosha}\n  ID: {IdStudenti}\n  Drejtimi: {Drejtimi}\n");
    }
}
