using System;

namespace VideoStore
{
    class VideoStore
    {
        private static List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new();
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void Checkout(string title)
        {
            foreach (Video video in _inventory)
            {
                if (video.Title == title)
                {
                    video.BeingCheckedOut();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (Video video in _inventory)
            {
                if (video.Title == title)
                {
                    video.BeingReturned();
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (Video video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (Video video in _inventory)
            {
                Console.WriteLine(video);
            }
        }
    }
}