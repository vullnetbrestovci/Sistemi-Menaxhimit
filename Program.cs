using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Person> persona = new List<Person>();

    static void Main(string[] args)
    {
        RegjistroProfesoraParazgjedhur();
        bool vazhdo = true;
        while (vazhdo)
        {
            Console.WriteLine("\nZgjidhni një opsion:\n");
            Console.WriteLine("1. Regjistro Student\n");
            Console.WriteLine("2. Regjistro Profesor\n");
            Console.WriteLine("3. Shfaq të gjitha personat\n");
            Console.WriteLine("4. Ruaj të dhënat në skedar\n");
            Console.WriteLine("5. Dil\n");

            string zgjedhje = Console.ReadLine();

            switch (zgjedhje)
            {
                case "1":
                    RegjistroStudent();
                    break;

                case "2":
                    RegjistroProfesor();
                    break;

                case "3":
                    ShfaqPersonat();
                    break;

                case "4":
                    RuajTeDhenat();
                    break;

                case "5":
                    vazhdo = false;
                    Console.WriteLine("Faleminderit që përdorët sistemin!");
                    break;

                default:
                    Console.WriteLine("Zgjedhje e pavlefshme, provoni përsëri.");
                    break;
            }
        }
    }

    static void RegjistroStudent()
    {
        Console.Write("Emri i Studentit: ");
        string emriStudent = Console.ReadLine();

        int moshaStudent;
        while (true)
        {
            Console.Write("Mosha: ");
            if (int.TryParse(Console.ReadLine(), out moshaStudent) && moshaStudent >= 18 && moshaStudent <= 30)
            {
                break;
            }
            Console.WriteLine("Ju lutem konfirmoni moshen.");
        }

        Console.Write("ID e Studentit: ");
        int idStudent = int.Parse(Console.ReadLine());
        Console.Write("Drejtimi: ");
        string drejtimi = Console.ReadLine();

        persona.Add(new Student
        {
            Emri = emriStudent,
            Mosha = moshaStudent,
            IdStudenti = idStudent,
            Drejtimi = drejtimi
        });
        Console.WriteLine("Studenti u regjistrua me sukses!\n");
    }

    static void RegjistroProfesor()
    {
        Console.Write("Emri i Profesorit: ");
        string emriProfesor = Console.ReadLine();

        int moshaProfesor;
        while (true)
        {
            Console.Write("Mosha: ");
            if (int.TryParse(Console.ReadLine(), out moshaProfesor) && moshaProfesor >= 20 && moshaProfesor <= 70)
            {
                break;
            }
            Console.WriteLine("Ju lutem konfirmoni moshen.");
        }

        Console.Write("ID e Profesorit: ");
        int idProfesor = int.Parse(Console.ReadLine());
        Console.Write("Lënda: ");
        string lenda = Console.ReadLine();
        Console.Write("Dita: ");
        string dita = Console.ReadLine();

        string ora;
        while (true)
        {
            Console.Write("Ora (formati: hh:mm-hh:mm): ");
            ora = Console.ReadLine();
            if (System.Text.RegularExpressions.Regex.IsMatch(ora, "^\d{1,2}:\d{2}-\d{1,2}:\d{2}$"))
            {
                break;
            }
            Console.WriteLine("Ju lutem konfirmoni orën në formatin hh:mm-hh:mm.");
        }

        persona.Add(new Professor
        {
            Emri = emriProfesor,
            Mosha = moshaProfesor,
            IdProfesori = idProfesor,
            Lenda = lenda,
            Dita = dita,
            Ora = ora
        });
        Console.WriteLine("Profesori u regjistrua me sukses!\n");
    }

    static void ShfaqPersonat()
    {
        Console.WriteLine("\n===============================");
        Console.WriteLine("     Lista e Studentëve       ");
        Console.WriteLine("===============================");
        foreach (var person in persona)
        {
            if (person is Student)
            {
                person.ShfaqInformacion();
            }
        }

        Console.WriteLine("\n===============================");
        Console.WriteLine("     Lista e Profesorëve      ");
        Console.WriteLine("===============================");
        foreach (var person in persona)
        {
            if (person is Professor)
            {
                person.ShfaqInformacion();
            }
        }
        Console.WriteLine("===============================\n");
    }

    static void RuajTeDhenat()
    {
        string filePath = "persona.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var person in persona)
            {
                if (person is Student student)
                {
                    writer.WriteLine($"Student,{student.Emri},{student.Mosha},{student.IdStudenti},{student.Drejtimi}");
                }
                else if (person is Professor professor)
                {
                    writer.WriteLine($"Professor,{professor.Emri},{professor.Mosha},{professor.IdProfesori},{professor.Lenda},{professor.Dita},{professor.Ora}");
                }
            }
        }
        Console.WriteLine("Të dhënat u ruajtën me sukses në skedarin persona.txt.\n");
    }

    static void RegjistroProfesoraParazgjedhur()
    {
        persona.Add(new Professor { Emri = "Ilir Berisha", Mosha = 45, IdProfesori = 1, Lenda = "Struktura Diskrete", Dita = "E Mërkurë", Ora = "16:00-18:00" });
        persona.Add(new Professor { Emri = "Rrezart Prebreza", Mosha = 38, IdProfesori = 2, Lenda = "Algoritme dhe Struktura të të Dhënave", Dita = "E Enjte", Ora = "09:00-11:00" });
        persona.Add(new Professor { Emri = "Qendrim Hykaj", Mosha = 40, IdProfesori = 3, Lenda = "Hyrje në Telekomunikacion dhe Rrjeta Kompjuterike", Dita = "E Shtunë", Ora = "14:00-16:00" });
        persona.Add(new Professor { Emri = "Arianit Krypa", Mosha = 50, IdProfesori = 4, Lenda = "Sistemet Operative", Dita = "Self Paced", Ora = "Self Paced" });
        persona.Add(new Professor { Emri = "Besart Prebreza", Mosha = 34, IdProfesori = 5, Lenda = "Programim i Orientuar në Objekte", Dita = "Self Paced", Ora = "Self Paced" });
        persona.Add(new Professor { Emri = "Artan Aliu", Mosha = 29, IdProfesori = 6, Lenda = "Gjuhë Angleze Pre Intermediate", Dita = "Self Paced", Ora = "Self Paced" });
        Console.WriteLine("Profesorët parazgjedhur janë shtuar në sistem.\n");
    }
}
