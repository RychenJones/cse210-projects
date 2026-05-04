using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job = new Job();
        job._jobTitle = "Software Engineer";
        job._company = "Entrata";
        job._startYear = 2028;
        job._endYear = 2030;

        // job.Display();

        Job job1 = new Job();
        job1._jobTitle = "Senior Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2032;
        job1._endYear = 2036;

        // job1.Display();


        Resume resume = new Resume();
        resume._name = "Rychen Jones";
        resume._jobs.Add(job);
        resume._jobs.Add(job1);

        resume.Display();

        // Console.WriteLine(resume._jobs[0]);
    }
}