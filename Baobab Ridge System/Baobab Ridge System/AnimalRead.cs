using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Baobab_Ridge_System
{
    internal class AnimalRead
    {
        public string filepath = Path.Combine(Application.StartupPath, "Animals.txt");

        public List<Animal> readAnimal( out int skippedLines)
        {
            List<Animal> listOfAnimals = new List<Animal>();
            skippedLines = 0;

            if (!File.Exists(filepath))
            {
                using (File.Create(filepath))
                {

                }  
            }

            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
            {

                if (string.IsNullOrWhiteSpace(line))
                {
                    skippedLines++;
                    continue;
                }


                string[] fields = line.Split('|');


                if (fields.Length != 7)
                {
                    skippedLines++;
                    continue;
                }


                int age;
                int recoveryScore;


                if (!int.TryParse(fields[3], out age) || !int.TryParse(fields[4], out recoveryScore))
                {
                    skippedLines++;
                    continue;
                }


                try
                {
                    Animal animal = new Animal(fields[0], fields[1], fields[2], age, recoveryScore);
                    listOfAnimals.Add(animal);
                }
                catch (ArgumentException)
                {

                } 
            }
            return listOfAnimals;   
        }
    }
}
