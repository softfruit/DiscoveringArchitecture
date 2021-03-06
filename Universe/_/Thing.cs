﻿using System;
using Universe.__;

namespace Universe
{
    class Thing
    {
        public Thing()
        {
            Type = GetType().Name;
            Name = Type;
        }

        public string Name;

        public string Type;

        public void Act(string action) => 
            Act(action, ConsoleColor.DarkCyan);

        public void Act(string action,ConsoleColor color,int extraPadding = 14)
        {
            Write(Name.PadBoth(extraPadding), color);
            WriteLine($" - {action}",ConsoleColor.White);
        }

        public override string ToString()
        {
            return Type.Equals(Name, StringComparison.OrdinalIgnoreCase) ? Name : $"{Type} {Name}";
        }

        public void Write(object obj,ConsoleColor color)
        {
            ConsoleColor original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(obj);
            Console.ForegroundColor = original;
        }

        public void WriteLine(object obj, ConsoleColor color)
        {
            ConsoleColor original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(obj);
            Console.ForegroundColor = original;
        }
    }
}
