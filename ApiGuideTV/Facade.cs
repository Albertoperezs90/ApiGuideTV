using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiGuideTV.BC;
using ApiGuideTV.BE;
using ApiGuideTV.Utilities.Format;

namespace ApiGuideTV
{
    public class Facade
    {
        private static Facade instance;

        private Facade() { }

        public static Facade Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Facade();
                }
                return instance;
            }
        }

        public string LoadNowGuideTV()
        {
            List<ProgramResponse> programs = ProgramBC.Instance.LoadNowGuideTV();
            return ReflectionHelper.GetJsonFromObject(programs);
        }
    }
}