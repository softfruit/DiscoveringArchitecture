﻿namespace Universe.Examples.D
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";
            person.Eat();

        }
    }
}