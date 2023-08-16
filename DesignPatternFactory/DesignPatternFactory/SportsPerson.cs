using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactory
{
    public class SportsPerson
    {
        /* -- TRying to implkement a factory pattern 
         * --Main issue is the objects and instantiation of classes
         * -- factory static method or FACTORY CLASSES
         * 
         * 1 --> add a static method in the class you want to instantiate
         *G 2 --> Change the access specifier of the constructor to PRIVATE
         */
        public int Score { get; private set; }
        public int Level { get; private set; }
        public int Medals { get; private set; }

        // constructor -->to handle access
        private SportsPerson(int score, int level, int medals)
        {
            Score = score;
            Level = level;
            Medals = medals;

        }
        // static method --> factory method that instantiates the class
        public static SportsPerson CreateNewSportsPerson(int score, int level, int medals)
        {
            Console.WriteLine("Score: " + score + "\n"
                + "Level: " + level + "\n"
                + "Medals: " + medals + "\n");
            return new SportsPerson(score, level, medals);
        }
    }
   
}
