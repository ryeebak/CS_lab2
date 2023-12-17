using System;
using System.Collections.Generic;

class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxinп");
    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excellent pupil studying well!");
    }

    public override void Read()
    {
        Console.WriteLine("Excellent pupil reads very good!");
    }

    public override void Write()
    {
        Console.WriteLine("Excellent pupil is excelent writer!");
    }

    public override void Relax()
    {
        Console.WriteLine("Excellent pupil don't know how to relax!");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Good pupil is good studying!");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil is good reading!");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil is good writing!");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil relaxing not so much!");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad pupil is studying bad!");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil reading bad!");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil is so bad at writing!");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil relaxing so much!");
    }
}

class ClassRoom
{
    private List<Pupil> pupils = new List<Pupil>();

    public void AddPupil(Pupil pupil)
    {
        pupils.Add(pupil);
    }

    public void StartLesson()
    {
        Console.WriteLine("\nClass is starting a lesson.");
        foreach (var pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void ReadingTime()
    {
        Console.WriteLine("\nIt's reading time.");
        foreach (var pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void WritingTime()
    {
        Console.WriteLine("\nIt's writing time.");
        foreach (var pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void RelaxTime()
    {
        Console.WriteLine("\nIt's relaxing time.");
        foreach (var pupil in pupils)
        {
            pupil.Relax();
        }
    }
}

class lab021
{
    static void Main(string[] args)
    {
        ClassRoom classRoom = new ClassRoom();

        int totalPupils = 0;

        while (totalPupils < 2 || totalPupils > 5)
        {
            Console.Write("Enter the number of Pupils (2 to 5): ");
            totalPupils = int.Parse(Console.ReadLine());

            if (totalPupils < 2 || totalPupils > 5)
            {
                Console.WriteLine("Not good. Try again");
            }
        }

        int excellentCount = 0;
        int goodCount = 0;
        int badCount = 0;

        for (int i = 0; i < totalPupils; i++)
        {
            Console.Write($"Enter type of pupil {i + 1} (1 for Excellent, 2 for Good, 3 for Bad): ");
            int pupilType = int.Parse(Console.ReadLine());

            switch (pupilType)
            {
                case 1:
                    classRoom.AddPupil(new ExcellentPupil());
                    excellentCount++;
                    break;
                case 2:
                    classRoom.AddPupil(new GoodPupil());
                    goodCount++;
                    break;
                case 3:
                    classRoom.AddPupil(new BadPupil());
                    badCount++;
                    break;
                default:
                    Console.WriteLine("Nice try. Let's try again:");
                    i--;
                    break;
            }
        }

        Console.WriteLine($"Excellent Pupils: {excellentCount}");
        Console.WriteLine($"Good Pupils: {goodCount}");
        Console.WriteLine($"Bad Pupils: {badCount}");

        classRoom.StartLesson();
        classRoom.ReadingTime();
        classRoom.WritingTime();
        classRoom.RelaxTime();
    }
}
