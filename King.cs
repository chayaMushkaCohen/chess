using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class King : Tool
    {

        public King(string name, bool isWhite) : base(name, isWhite)
        {

        }
        public override bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            if ((chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == 0))
                return true;
            else if ((chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == -1))
                return true;
            else if ((chosenPLaceX - initialPLaceX == 0) && (chosenPlaceY - initialPlaceY == -1))
                return true;
            else if ((chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == -1))
                return true;
            else if ((chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == 0))
                return true;
            else if ((chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == 1))
                return true;
            else if ((chosenPLaceX - initialPLaceX == 0) && (chosenPlaceY - initialPlaceY == 1))
                return true;
            else if ((chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == 1))
                return true;
            return false;
        }

    }
}
