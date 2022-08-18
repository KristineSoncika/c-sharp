using System;

namespace AdApp
{
    class Program
    {
        private static void Main()
        {
            var campaign = new Campaign("Plant a Tree!");
            campaign.AddAdvert(new Advert(1000));
            campaign.AddAdvert(new Hoarding(500, 7, 200, false));
            campaign.AddAdvert(new NewspaperAd(0, 30, 20));
            campaign.AddAdvert(new TVAd(50000, 1000, 30, true));
            campaign.AddAdvert(new Poster(350, 3, 300, true));
            Console.WriteLine(campaign);
        }
    }
}