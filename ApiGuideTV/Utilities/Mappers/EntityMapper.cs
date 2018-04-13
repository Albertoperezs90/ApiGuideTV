using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiGuideTV.BE;

namespace ApiGuideTV.Utilities.Mappers
{
    public static class EntityMapper
    {
        public static Program ConvertProgramResponseToProgram(ProgramResponse response)
        {
            return new Program()
            {
                GenericType = response.GenericType,
                Id = response.Id,
                Channel = new Channel()
                {
                    Id = response.IdChannel
                },
                Type = response.Type,
                Title = response.Title,
                Category = response.Category,
                Description = response.Description,
                Score = response.Score,
                Image = response.Image,
                EpochStart = response.EpochStart,
                EpochEnd = response.EpochEnd
            };
        }
    }
}