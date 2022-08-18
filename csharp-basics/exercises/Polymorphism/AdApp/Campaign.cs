using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;
        private string _name;

        public Campaign(string name)
        {
            _campaign = new();
            _name = name;
        }

        public void AddAdvert(Advert ad)
        {
            _campaign.Add(ad);
        }

        public double GetCost()
        {
            return _campaign.Sum(item => item.Cost());
        }

        public string GetName()
        {
            return _name;
        }

        public override string ToString()
        {
            return  $"Advert Campaign: {GetName()}\n" +
                    $"Total Cost: {GetCost().ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"))}";
        }
    }
}