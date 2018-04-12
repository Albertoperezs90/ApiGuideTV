using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiGuideTV.BE;

namespace ApiGuideTV.Utilities.Mappers
{
    public static class JsonMapper
    {
        public static List<ProgramResponse> MapJsonDataResponseToProgramResponse(JsonDataResponse apiResponse)
        {
            List<ProgramResponse> response = new List<ProgramResponse>();
            foreach (List<string> programValues in apiResponse.data)
            {
                ProgramResponse programResponse = new ProgramResponse()
                {
                    Category = programValues[0],
                    Id = programValues[1],
                    IdChannel = programValues[2],
                    Type = programValues[3],
                    Title = programValues[4],
                    AnotherCategory = programValues[5],
                    Nose = programValues[6],
                    Nil = programValues[7],
                    Image = programValues[8],
                    EpochStart = programValues[9],
                    EpochEnd = programValues[10]
                };
                response.Add(programResponse);
            }

            return response;
        }
    }
}