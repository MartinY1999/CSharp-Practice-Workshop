using System;

namespace MordorsCruelPlan
{
    public class Gandalf
    {
        public string Mood { get; private set; }
        public int Points { get; set; }
        public void GetMood()
        {
            Points = this.GetPoints();
            if (Points < -5)
                Mood = "Angry";
            else if (Points >= -5 && Points <= 0)
                Mood =  "Sad";
            else if (Points >= 1 && Points <= 15)
                Mood = "Happy";
            else
                Mood = "JavaScript";
        }
        private int GetPoints()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int points = 0;
            foreach (string part in input)
            {
                if (part.ToLower() == "cram")
                    points += (int)Foods.Cram;
                else if (part.ToLower() == "lembas")
                    points += (int)Foods.Lembas;
                else if (part.ToLower() == "apple")
                    points += (int)Foods.Apple;
                else if (part.ToLower() == "melon")
                    points += (int)Foods.Melon;
                else if (part.ToLower() == "honeycake")
                    points += (int)Foods.HoneyCake;
                else if (part.ToLower() == "mushrooms")
                    points -= (int)Foods.Mushrooms;
                else
                    points -= (int)Foods.AnythingElse;
            }
            return points;
        }
    }
}
