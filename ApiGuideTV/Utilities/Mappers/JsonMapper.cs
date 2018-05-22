using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiGuideTV.BE;
using ApiGuideTV.BE.DAO;
using Newtonsoft.Json;

namespace ApiGuideTV.Utilities.Mappers
{
    public static class JsonMapper
    {
        public static ProgramsResponse MapJsonDataResponseToProgramResponse(JsonDataResponse apiResponse)
        {
            ProgramsResponse programs = new ProgramsResponse();
            programs.response = new List<ProgramResponse>();
            foreach (List<string> programValues in apiResponse.Data)
            {
                ProgramResponse programResponse = new ProgramResponse()
                {
                    GenericType = programValues[0],
                    Id = programValues[1],
                    IdChannel = programValues[2],
                    Type = programValues[3],
                    Title = programValues[4],
                    Category = programValues[5],
                    Description = programValues[6],
                    Score = programValues[7],
                    Image = programValues[8],
                    EpochStart = programValues[9],
                    EpochEnd = programValues[10]
                };
                programs.response.Add(programResponse);
            }

            return programs;
        }


        public static string MapErrorToJson(BE.Status error)
        {
            return JsonConvert.SerializeObject(error);
        }
    }
}