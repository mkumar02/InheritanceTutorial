using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTutorial
{
    class Dog : Animal      //Child (Derived) class
    {
        public override string GetAnimalSound()
        {
            return "Bow Bow";
        }
    }
}
