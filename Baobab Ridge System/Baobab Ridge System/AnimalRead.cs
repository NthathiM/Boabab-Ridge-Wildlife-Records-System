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

        //to update one animal record while still keeping the other file lines.
        public void UpdateAnimal(Animal updatedAnimal)
        {
            if(updatedAnimal == null)
            {
                throw new ArgumentNullException(nameof(updatedAnimal));
            }

            //read the og lines to keep the file's existing records
            List<string> lines = File.ReadAllLines(filepath).ToList();

            int matchingIndex = -1;


            //find record using its id and also ignore letter case
            for (int i = 0; i < lines.Count; i++)
            {
                string[] items = lines[i].Split('|');
            
                if(items.Length == 7 && items[0].Trim().Equals(updatedAnimal.AnimalID,StringComparison.OrdinalIgnoreCase))
                {
                    matchingIndex = i;
                    break;
                }
            }

            //stop if animal doen't exist
            if(matchingIndex == -1)
            {
                throw new InvalidOperationException("Animal could not be found.");
            }

            //replaces only the match with the updated or new values
            lines[matchingIndex] = string.Join("|",
                updatedAnimal.AnimalID,
                updatedAnimal.Name,
                updatedAnimal.Species,
                updatedAnimal.Age,
                updatedAnimal.RecoveryScore,
                updatedAnimal.Status,
                updatedAnimal.HousingUnit
                 );

            File.WriteAllLines( filepath, lines );  //save the records without changing their order
        }


    }
}
