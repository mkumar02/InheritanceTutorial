using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTutorial
{
    class Animal        //Base (Parent) Class
    {
        public string AnimalType;

        public string ReturnType()
        {
            return AnimalType;
        }

        public virtual string GetAnimalSound()
        {
            return "Animal makes a sound";
        }
    }
}
