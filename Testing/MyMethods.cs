using System;

namespace WarriorStatus
{
    public class MyMethods
    {
        public static void CalculateWarriorStatus(int hp,
            out string status,
            out double speedPercentage,
            out double attackPercentage,
            out bool canRun,
            out string screenColor)
        {
            // Limit maximum HP to 100
            hp = Math.Min(hp, 100);

            // Determine status based on HP
            if (hp == 0)
            {
                status = "Dead";
                speedPercentage = 0;
                attackPercentage = 0;
                canRun = false;
                screenColor = "red";
            }
            else if (hp >= 1 && hp <= 25)
            {
                status = "Critical";
                speedPercentage = 50;
                attackPercentage = 50;
                canRun = false;
                screenColor = "normal";
            }
            else if (hp >= 26 && hp <= 50)
            {
                status = "Severely Injured";
                speedPercentage = 70;
                attackPercentage = 80;
                canRun = false;
                screenColor = "normal";
            }
            else if (hp >= 51 && hp <= 75)
            {
                status = "Injured";
                speedPercentage = 90;
                attackPercentage = 100;
                canRun = true;
                screenColor = "normal";
            }
            else // hp between 76 and 100
            {
                status = "Healthy";
                speedPercentage = 100;
                attackPercentage = 100;
                canRun = true;
                screenColor = "normal";
            }
        }
    }
}
