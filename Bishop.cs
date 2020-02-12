using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class Bishop : Tool
    {

        public Bishop (string name, bool isWhite) : base (name, isWhite)
        {
            
        }
        public override bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            int stepsInX = initialPLaceX - chosenPLaceX;
            int stepsInY = initialPlaceY - chosenPlaceY;
            for (int i = 0; i < 7; i++)
            {
                if ((stepsInX == i) && (stepsInY == i))
                    return true;
                else if ((stepsInX == i) && (stepsInY == -i))
                    return true;
                else if ((stepsInX == -i) && (stepsInY == -i))
                    return true;
                else if ((stepsInX == -i) && (stepsInY == i))
                    return true;
            }

            return false;
        }
    }
}
