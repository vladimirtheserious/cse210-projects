using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Apple";
        job1._jobTitle = "Software Engeneer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "SoftWare Engeneer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();

        myResume._name = "Vladimir Sychugov";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();


    }
}