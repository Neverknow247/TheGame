using System;
using TheGame.Models;

namespace TheGame.Models
{
    public abstract class Chimps : Enemies
    {
        public Chimps() : base("Chimps", 100, 90, 25)
        {
            // Assign values coming in to the fields
        }
    }
}