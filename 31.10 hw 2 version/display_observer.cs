using System;

namespace Tamagotchi
{
    public class DisplayObserver
    {
        private Pet pet;

        public DisplayObserver(Pet pet)
        {
            this.pet = pet;
            pet.request_event += display_pet;
            pet.status_event += display_message;
            pet.death_event += display_death;
        }

        private void display_pet(string request)
        {
            Console.Clear();
            Console.WriteLine($"Energy: {pet.get_energy()}%");
            Console.WriteLine("     *****     ");
            Console.WriteLine("   *       *   ");
            Console.WriteLine("  *  O   O  *  ");
            Console.WriteLine(" *     v     * ");
            Console.WriteLine("   *       *   ");
            Console.WriteLine("     *****     ");
            Console.WriteLine();
            Console.WriteLine(request);
            Console.WriteLine("Fulfill the request? Y / N");
            
            var response = Console.ReadKey(true).Key;
            Console.WriteLine();

            if (response == ConsoleKey.Y)
            {
                pet.answer_request(true);
                Console.ForegroundColor = ConsoleColor.Magenta; 
                Console.WriteLine("     *****     ");
                Console.WriteLine("   *       *   ");
                Console.WriteLine("  *  ^   ^  *  ");
                Console.WriteLine(" *     v     * ");
                Console.WriteLine("   *       *   ");
                Console.WriteLine("     *****     ");
                Console.ResetColor();
            }
            else if (response == ConsoleKey.N)
            {
                pet.answer_request(false);
            }
        }

        private void display_message(string message)
        {
            Console.WriteLine(message);
        }

        private void display_death()
        {
            Console.Clear();
            Console.WriteLine($"Energy: {pet.get_energy()}%");
            Console.WriteLine("The Tamagotchi has died...");
        }
    }
}
