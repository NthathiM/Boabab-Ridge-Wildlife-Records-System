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
        public string filepath = Path.Combine(Application.StartupPath, "animals.txt");
        

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

            //check file existence
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Animal data file could not be found.", filepath);
            }



            //read the og lines to keep the file's existing records and check if any records are there
            List<string> lines = File.ReadAllLines(filepath).ToList();

            if(lines.Count == 0)
            {
                throw new InvalidOperationException("Animal data file is empty. There are no records to update.");
            }

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
                throw new InvalidOperationException("Animal ID could not be found. Therefore no records were changed!");
            }

            //replaces only the matching record with the updated or new values
            lines[matchingIndex] = string.Join("|",
                updatedAnimal.AnimalID.Trim(),
                updatedAnimal.Name.Trim(),
                updatedAnimal.Species.Trim(),
                updatedAnimal.Age,
                updatedAnimal.RecoveryScore,
                updatedAnimal.Status,
                updatedAnimal.HousingUnit
                 );

            File.WriteAllLines( filepath, lines );  //save the records without changing their order
        }

        // delete records
        public void DeleteAnimal(string animalID)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Animal data file could not be found.", filepath);
            }

            List<string> lines = File.ReadAllLines(filepath).ToList();
            List<string> keptLines = new List<string>();

            foreach (string line in lines)
            {
                string[] items = line.Split('|');

                // keep every line EXCEPT the one whose ID matches
                if (!items[0].Trim().Equals(animalID, StringComparison.OrdinalIgnoreCase))
                {
                    keptLines.Add(line);
                }
            }

            File.WriteAllLines(filepath, keptLines);
        }


    }
}
