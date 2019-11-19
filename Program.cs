using System;

namespace HeisterExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist");
            Console.WriteLine();
            Heister teamMember;

            Console.WriteLine("What is the team member's name");
            String name = Console.ReadLine();

            Console.WriteLine("What is the team member's skill level");
            String skillLevelString = Console.ReadLine();
            int skillLevel;

            try
            {
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{skillLevelString} is not a valid skill level.");
                skillLevel = 10;
            }

            Console.WriteLine("What is the team member's courage factor");
            String courageFactorString = Console.ReadLine();
            decimal courageFactor;
            try
            {
                courageFactor = decimal.Parse(courageFactorString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{courageFactorString} is not a valid courage factor");
                courageFactor = 1.0M;
            }

            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor
            };
            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");
        }
    }
}