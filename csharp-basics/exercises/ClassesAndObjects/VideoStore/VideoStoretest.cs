using System;

namespace VideoStore
{
    class VideoStoretest
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();

        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill the video store");
                Console.WriteLine("Choose 2 to rent a video (as user)");
                Console.WriteLine("Choose 3 to return a video and give a rating (as user)");
                Console.WriteLine("Choose 4 to list inventory");

                int choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            _videoStore.ListInventory();
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                Console.WriteLine("Enter movie name");
                string movieName = Console.ReadLine(); 

                _videoStore.AddVideo(movieName);
            }
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            _videoStore.Checkout(movieName);
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();

            Console.WriteLine("Enter rating");
            int rating = Convert.ToInt16(Console.ReadLine());

            _videoStore.ReturnVideo(movieName);
            _videoStore.TakeUsersRating(rating, movieName);
        }
    }
}