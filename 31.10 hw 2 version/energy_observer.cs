using System;

namespace Tamagotchi
{
    public class EnergyObserver
    {
        public EnergyObserver(Pet pet)
        {
            pet.energy_changed_event += energy_changed;
        }

        private void energy_changed(int energy)
        {
            Console.WriteLine($"Energy changed to {energy}%");
        }
    }
}