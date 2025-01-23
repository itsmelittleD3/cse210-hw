using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "(Microsoft)";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job1._company = "(Apple)";
        job1._jobTitle = "Manager";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Resume myResume = new resume();
        myresume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
    
    
}