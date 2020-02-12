using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class Queen : Tool
    {
        public Queen(string name, bool isWhite) : base (name, isWhite)
        {

        }
        public override bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            int stepsInX = initialPLaceX - chosenPLaceX;
            int stepsInY = initialPlaceY - chosenPlaceY;
            for (int i = 1; i < 7; i++)
            {
                if ((stepsInX == i) && (stepsInY == i)) // queen is stepping like a bishop
                    return true;
                else if ((stepsInX == i) && (stepsInY == -i))
                    return true;
                else if ((stepsInX == -i) && (stepsInY == -i))
                    return true;
                else if ((stepsInX == -i) && (stepsInY == i))
                    return true;
                else if ((stepsInX == 0) && (stepsInY == i)) // queen is steping like right to left
                    return true;
                else if ((stepsInX == 0) && (stepsInY == -i))
                    return true;
                else if ((stepsInX == i) && (stepsInY == 0)) // queen is steping up and down
                    return true;
                else if ((stepsInX == -i) && (stepsInY == 0))
                    return true;
            }

            return false;
        }
    }
}
