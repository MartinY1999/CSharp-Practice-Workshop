﻿using System;

namespace Animals
{
    public abstract class Animals
    {
        private string name;
        private int age;
        private string gender;

        public Animals(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        private string Name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new CustomException();
                }
                this.name = value;
            }
        }
        private int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new CustomException();
                }
                this.age = value;
            }
        }
        private string Gender
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new CustomException();
                }
                this.gender = value;
            }
        }
        public abstract string ProduceSound();
        public override string ToString()
        {
            return string.Format("{0}{1}{2} {3} {4}{1}{5}",
                this.GetType().Name, // 0
                Environment.NewLine, // 1
                this.name, // 2
                this.age,  // 3
                this.gender, // 4
                this.ProduceSound()); // 5
        }
    }
}
