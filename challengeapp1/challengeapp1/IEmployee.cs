﻿namespace challengeapp1
{
    internal interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
