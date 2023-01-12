using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Apple Eater";
        job1._startYear = "1843";
        job1._endYear = "1846";

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Computer Man";
        job2._startYear = "1943";
        job2._endYear = "1946";

        Resume myResume = new Resume();
        myResume._name = "Bradley Tanner";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}