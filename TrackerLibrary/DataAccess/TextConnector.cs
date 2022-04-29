using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection

        
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Wire up the CreatePrize for text files

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            //Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            // order the list by ID in descending order then increament ID for new ID
            int currentId = 1;

            // if statement to make sure that a new ID is created should the file already have items
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);
            

            // Convert the prizesto list<string>
            // Save the List<strng> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
