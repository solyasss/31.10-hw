using System;

namespace Tamagotchi
{
    public class IgnoreObserver
    {
        public IgnoreObserver(Pet pet)
        {
            pet.ignore_request_event += ignore_request;
        }

        private void ignore_request(int ignore_count)
        {
            Console.WriteLine($"Requests ignored: {ignore_count}");
        }
    }
}