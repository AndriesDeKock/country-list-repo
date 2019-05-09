using System.Collections.Generic;

namespace CountryList
{
    public class GetCountryList
    {
        public List<string> RetrieveGlobalCountryList()
        {
            //create list object to populate with countries
            List<string> culturelist = new List<string>();
            //get cultures from spesific culture type
            System.Globalization.CultureInfo[] cultureInfos = System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.SpecificCultures);
            //loop through results
            foreach (System.Globalization.CultureInfo getCultureInfo in cultureInfos)
            {
                //retrieve regional information based on culture indentifier
                System.Globalization.RegionInfo regionInfo = new System.Globalization.RegionInfo(getCultureInfo.LCID);
                //ensure no duplicate regions are added to the list
                if (!culturelist.Contains(regionInfo.EnglishName))
                {
                    //add region info to list
                    culturelist.Add(regionInfo.EnglishName);
                }
            }
            
            //sort list
            culturelist.Sort();
            //return list
            return culturelist;
        }
    }
}