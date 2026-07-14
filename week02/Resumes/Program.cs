using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
        job1.company = "Company A";
        job1.jobTitle = "Software Engineer";
        job1.startYear = "2020";
        job1.endYear = "2022";

        Job job2 = new Job();
        job2.company = "Company B";
        job2.jobTitle = "Senior Developer";
        job2.startYear = "2022";
        job2.endYear = "Present";

        Resume resume = new Resume();
        resume.name = "John Doe";
        resume.jobs.Add(job1);
        resume.jobs.Add(job2);

        resume.Display();
    }
}