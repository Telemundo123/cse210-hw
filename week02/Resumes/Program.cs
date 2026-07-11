using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Created the first job object 
        Job job1 = new Job();
        job1._company = "LinkedIn";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2024;

        // Created the second job object
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Senior UX/UI Designer";
        job2._startYear = 2024;
        job2._endYear = 2026;

        // Created the resume object
        Resume myResume = new Resume();
        myResume._name = "John Doe";

        // Added the job objects to the resume's job list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();

    }
}