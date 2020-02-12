using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class Rook : Tool
    {

        public Rook(string name, bool isWhite) : base(name, isWhite)
        {
            
        }
        public override bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            if(initialPLaceX - chosenPLaceX == 0)
            {
                if (initialPlaceY - chosenPlaceY == 1) 
                {
                    return true;
                }
                else if (initialPlaceY - chosenPlaceY == 2)
                {
                    return true;
                }
                else if (initialPlaceY - chosenPlaceY == 3) 
                {
                    return true;
                }
                else if (initialPlaceY - chosenPlaceY == 4) 
                {
                    return true;
                }
                else if (initialPlaceY - chosenPlaceY == 5)
                {
                    return true;
                }
                else if (initialPlaceY - chosenPlaceY == 6)
                {
                    return true;
                }
                else if (initialPlaceY - chosenPlaceY == 7)
                {
                    return true;
                }


                else if ((initialPlaceY - chosenPlaceY == -1) || (initialPlaceY - chosenPlaceY == -2) || (initialPlaceY - chosenPlaceY == -3) || (initialPlaceY - chosenPlaceY == -4) || (initialPlaceY - chosenPlaceY == -5) || (initialPlaceY - chosenPlaceY == -6) || (initialPlaceY - chosenPlaceY == -7))
                {
                    return true;
                }
            }

            else if (initialPlaceY - chosenPlaceY == 0)
            {
                if ((initialPLaceX - chosenPLaceX == 1) || (initialPLaceX - chosenPLaceX == 2) || (initialPLaceX - chosenPLaceX == 3) || (initialPLaceX - chosenPLaceX == 4) || (initialPLaceX - chosenPLaceX == 5) || (initialPLaceX - chosenPLaceX == 6) || (initialPLaceX - chosenPLaceX == 7))
                {
                    return true;
                }
                else if ((initialPLaceX - chosenPLaceX == -1) || (initialPLaceX - chosenPLaceX == -2) || (initialPLaceX - chosenPLaceX == -3) || (initialPLaceX - chosenPLaceX == -4) || (initialPLaceX - chosenPLaceX == -5) || (initialPLaceX - chosenPLaceX == -6) || (initialPLaceX - chosenPLaceX == -7))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
