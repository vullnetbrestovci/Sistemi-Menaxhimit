public class Professor : Person
{
    public string Lenda { get; set; }
    public int IdProfesori { get; set; }
    public string Dita { get; set; }
    public string Ora { get; set; }

    public override void ShfaqInformacion()
    {
        Console.WriteLine($"Profesor: {Emri}\n  Mosha: {Mosha}\n  ID: {IdProfesori}\n  Lënda: {Lenda}\n  Dita: {Dita}\n  Ora: {Ora}\n");
    }
}