using System;

namespace DelegatesAndEventsPractice.Events
{
    


    public class Player
    {
        //public delegate void DeathDelegate();



        public event Action deathEvent;

        void Die()
        {
            //Die
            deathEvent?.Invoke();
        }
    }

    public class Achievements
    {
        void Start(Player player)
        {
            player.deathEvent += OnPlayerDeath;
            
        }

        public void OnPlayerDeath(Player player)
        {
            player.deathEvent -= OnPlayerDeath;
        }
    }

    public class UserInterface
    {
        void Start(Player player)
        {
            player.deathEvent += OnPlayerDeath;
        }

        public void OnPlayerDeath(Player player)
        {
            player.deathEvent -= OnPlayerDeath;
        }
    }
}
