using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTutorial
{
    class Lion : Animal         //Child (Derived) class
    {
        public override string GetAnimalSound()
        {
            return "Roar";
        }
    }
}
