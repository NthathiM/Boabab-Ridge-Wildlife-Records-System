using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Baobab_Ridge_System
{
    internal class Animal
    {

        public string AnimalID { get; private set; }
        public string Name { get; private set; }
        public string Species { get; private set; }
        public int Age { get; private set; }
        public int RecoveryScore { get; private set; }
        public string Status { get; private set; }
        public string HousingUnit { get; private set; }

        private void Classification()
        {
           if (RecoveryScore <= 19 && RecoveryScore >= 0)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if (RecoveryScore >= 20 && RecoveryScore <= 39)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if (RecoveryScore >= 40 && RecoveryScore <= 59)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (RecoveryScore >= 60 && RecoveryScore <= 79)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else if (RecoveryScore >= 80 && RecoveryScore <= 100)
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
        }

        

        public Animal(string animalID, string name, string species, int age, int recoveryScore)
        {
            AnimalID = ValidateID(animalID);
            Name = ValidateText(name);
            Species = ValidateText(species);
            Age = ValidateInt(age);
            RecoveryScore = ValidateInt(recoveryScore);
            Classification();
            
        }

        private string ValidateID(string id)
        {
           id = id.Trim().ToUpper();
            if (!Regex.IsMatch(id, @"^WR-\d{4}$"))
            {
                throw new ArgumentException("Animal ID must be in the form WR-XXXX.");
            }
            return id;
        }

        private string ValidateText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("Text cannot be empty.");
            }

            text = text.Trim();

            if (text.Length > 30 || text.Length < 1)
            {
                throw new ArgumentException("Text must be between 1 and 30 characters.");
            }

            if (text.Contains("|"))
            {
                throw new ArgumentException("Text cannot contain the '|' character.");
            }
           
            return text;
                
        }

        private int ValidateInt(int number)
        {
            if (number < 0 || number > 100)
            {
                throw new ArgumentException("This value must be between 0 and 100.");
            }
            return number;
        }

    }
}
