using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class Tool
    {
        string name;
        bool isWhite;
        public Tool(string name, bool isWhite)
        {
            this.name = name;
            this.isWhite = isWhite;

        }
        public string getNmae()
        {
            return this.name;
        }
        public bool getType()
        {
            return this.isWhite;
        }
        public virtual bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            return false;
        }


        public bool getIsWhite() // function to get the name of eaten tool
        {
            return isWhite;
        }
        public virtual bool BlackPawnIsEaten (string name)
        {
            return false;
        }

    }
}
