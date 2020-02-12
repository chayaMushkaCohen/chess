using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class Knight : Tool
    {

        public Knight (string name, bool isWhite) : base (name, isWhite)
        {
        }
        public override bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            int stepsInX = chosenPLaceX - initialPLaceX;
            int stepsInY = chosenPlaceY - initialPlaceY;

            if ((stepsInX == 1) && (stepsInY == 2))
                return true;
            else if ((stepsInX == 1) && (stepsInY == -2))
                return true;
            else if ((stepsInX == 2) && (stepsInY == 1))
                return true;
            else if ((stepsInX == 2) && (stepsInY == -1))
                return true;
            else if ((stepsInX == -1) && (stepsInY == -2))
                return true;
            else if ((stepsInX == -2) && (stepsInY == 1))
                return true;
            else if ((stepsInX == -1) && (stepsInY == 2))
                return true;
            else if ((stepsInX == -2) && (stepsInY == -1))
                return true;



            return false;
        }
    }
}
