using System;
using System.Collections.Generic;
using System.Text;

namespace chessTrying
{
    class Pawn : Tool
    {

        int[,] pawnsOfNotFirstStep = new int[9, 9]; // this is an array which includes values of pawn who used double step
        
        public Pawn(string name, bool isWhite) : base(name, isWhite)
        {

        }


        public override bool go(int initialPLaceX, int initialPlaceY, int chosenPLaceX, int chosenPlaceY, int countSteps, bool checkIfChosenPlaceIsEmpty)
        {
            if (checkIfChosenPlaceIsEmpty) // if the chosen place is  empty, then it can move on the regular way
            {
                if (countSteps % 2 == 1) // this is black turn 
                {
                    if ((chosenPLaceX - initialPLaceX == 0) && (chosenPlaceY - initialPlaceY == 1))
                        return true;
                    else if ((chosenPLaceX - initialPLaceX == 0) && (chosenPlaceY - initialPlaceY == 2) && (pawnsOfNotFirstStep[initialPLaceX, initialPlaceY] == 0) && initialPlaceY == 2) // pawn is in its first step
                    {
                        pawnsOfNotFirstStep[initialPLaceX, initialPlaceY] = 1;
                        return true;
                    }
                }
                else // this is white turn
                {
                    if (countSteps % 2 == 0) // this is white turn 
                    {
                        if ((initialPLaceX - chosenPLaceX == 0) && (initialPlaceY - chosenPlaceY == 1))
                            return true;
                        else if ((initialPLaceX - chosenPLaceX == 0) && (initialPlaceY - chosenPlaceY == 2) && (pawnsOfNotFirstStep[initialPLaceX, initialPlaceY] == 0) && initialPlaceY == 7) // pawn is in its first step
                        {
                            pawnsOfNotFirstStep[initialPLaceX, initialPlaceY] = 1;
                            return true;
                        }
                    }
                }
            }
            else if (! checkIfChosenPlaceIsEmpty) // the chosen place is not empty. then it can eat diagonaly  
            {
                if ((countSteps % 2 == 0) && (chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == -1)) // option 1 for white pawn
                    return true;
                else if ((countSteps % 2 == 0) && (chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == -1)) // option 2 for white pawn
                    return true;

                if ((countSteps % 2 == 1) && (chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == 1)) // option 1 for black pawn
                    return true;
                else if ((countSteps % 2 == 1) && (chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == 1)) // option 2 for black pawn
                    return true;

            }
            return false; // because the chosen place is not empty

            /*else if (! checkIfChosenPlaceIsEmpty) // the chosen place is not empty. then it caneat black pawn on "derech ipucho" 
            {
                if (countSteps % 2 == 0 && BlackPawnIsEaten(nameOfEatenTool)) // its white pawn, so the eaten pawn is black
                {
                    if (initialPlaceY == 5 && chosenPlaceY == 4) // the only location that optional for "derech ilucho" for white
                    {
                        if ((countSteps % 2 == 0) && (chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == -1)) // option 1 for white pawn
                            return true;
                        else if ((countSteps % 2 == 0) && (chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == -1)) // option 2 for white pawn
                            return true;
                    }
                    return false;
                }
                else if (!(BlackPawnIsEaten(nameOfEatenTool))) // its black pawn, then it can eat white pawn on derech ilucho
                {
                    if (initialPlaceY == 4 && chosenPlaceY == 5) // the only location that optional for "derech ilucho" for black
                    {
                        if ((countSteps % 2 == 1) && (chosenPLaceX - initialPLaceX == -1) && (chosenPlaceY - initialPlaceY == 1)) // option 1 for black pawn
                            return true;
                        else if ((countSteps % 2 == 1) && (chosenPLaceX - initialPLaceX == 1) && (chosenPlaceY - initialPlaceY == 1)) // option 2 for black pawn
                            return true;
                    }
                }
            }*/


        }
        public override bool BlackPawnIsEaten(string name)
        {
            if (name == "BlackPawn")
                return true;
            return false;
        }

    }
}
