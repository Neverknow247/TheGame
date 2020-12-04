using System;
using TheGame.Models;

namespace TheGame.Models
{
    public abstract class Boss : Enemies
    {
        public Boss() : base("Boss", 100, 100, 100)
        {
            // Assign values coming in to the fields
        }
    }
}