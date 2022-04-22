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
        // TODO - Wire up the CreatePrize for text files

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            //Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            // order the list by ID in descending order then increament ID for new ID
            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);
            
            
            
            
            // Convert the prizesto list<string>
            // Save the List<strng> to the text file
        }
    }
}
