using System;

namespace chessTrying
{
    class Program
    {
        static void Main(string[] args)
        {
            Board myBoard = new Board();
            myBoard.printBoard();
            int countingSteps = Board.getCountSteps();
            while (countingSteps < 50)
            {
                myBoard.currentalTurns();
                myBoard.choosingAct();
                myBoard.printBoard();
            }
        }
    }



    class Board 
    {

        Tool[,] board;
        static int countSteps = 0;
        static public int getCountSteps()
        {
            return countSteps;
        }
        public Board()
        {
            board = new Tool[9, 9];

            board[1, 1] = new Rook("BlackRook", false);
            board[2, 1] = new Knight("BlackKnight", false);
            board[3, 1] = new Bishop("BlackBishop", false);
            board[4, 1] = new Queen("BlackQueen", false);
            board[5, 1] = new King("BlackKing", false);
            board[6, 1] = new Bishop("BlackBishop", false);
            board[7, 1] = new Knight("BlackKnight", false);
            board[8, 1] = new Rook("BlackRook", false);
            for (int i = 1; i < 9; i++)
            {
                board[i, 2] = new Pawn("BlackPawn", false);
            }
            board[1, 8] = new Rook("WhiteRook", true);
            board[2, 8] = new Knight("WhiteKnight", true);
            board[3, 8] = new Bishop("WhiteBishop", true);
            board[4, 8] = new Queen("WhiteQueen", true);
            board[5, 8] = new King("WhiteKing", true);
            board[6, 8] = new Bishop("WhiteBishop", true);
            board[7, 8] = new Knight("WhiteKnight", true);
            board[8, 8] = new Rook("WhiteRook", true);
            for (int i = 1; i < 9; i++)
            {
                board[i, 7] = new Pawn("WhitePawn", true);
            }
        }
        public void printBoard()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write(i + "   ");
                        }
                    }

                    if (board[j, i] != null)
                    {
                        switch (board[j, i].getNmae())
                        {
                            case "BlackBishop":
                                Console.Write("BB ");
                                break;
                            case "BlackQueen":
                                Console.Write("BQ ");
                                break;
                            case "BlackKing":
                                Console.Write("BK ");
                                break;
                            case "BlackPawn":
                                Console.Write("BP ");
                                break;
                            case "BlackRook":
                                Console.Write("BR ");
                                break;
                            case "BlackKnight":
                                Console.Write("BN ");
                                break;
                            case "WhiteBishop":
                                Console.Write("WB ");
                                break;
                            case "WhiteQueen":
                                Console.Write("WQ ");
                                break;
                            case "WhiteKing":
                                Console.Write("WK ");
                                break;
                            case "WhitePawn":
                                Console.Write("WP ");
                                break;
                            case "WhiteRook":
                                Console.Write("WR ");
                                break;
                            case "WhiteKnight":
                                Console.Write("WN ");
                                break;
                        }
                        Console.Write(" ");
                    }
                    else if (j != 0 )
                    {
                        string columnValue = "ABCDEFGH";
                        if (i == 0)
                        {
                            Console.Write(" " + columnValue[j - 1] + "  ");
                        }
                        else
                        {
                            Console.Write("EE  ");
                        }
                    }

                }
                Console.WriteLine("\n");
            }
        }
        public void currentalTurns()
        {
            Console.WriteLine("this is the turn of the {0} tools", countSteps % 2 == 0 ? "white" : "black");
        }
        public void choosingAct()
        {
            int wrong = 0; // its going to count the errors of user's choices
            int initialPlaceX = 0;
            int initialPlaceY = 0;
            int chosenPlaceX = 0;
            int chosenPlaceY = 0;
            string input = "";
            do
            {
                wrong = 0;
                initialPlaceX = 0;
                initialPlaceY = 0;
                chosenPlaceX = 0;
                chosenPlaceY = 0;
                Console.WriteLine("please enter the move you wanna do");
                input = Console.ReadLine();

                switch (input[0])
                {
                    case 'A':
                        initialPlaceX = 1;
                        break;
                    case 'B':
                        initialPlaceX = 2;
                        break;
                    case 'C':
                        initialPlaceX = 3;
                        break;
                    case 'D':
                        initialPlaceX = 4;
                        break;
                    case 'E':
                        initialPlaceX = 5;
                        break;
                    case 'F':
                        initialPlaceX = 6;
                        break;
                    case 'G':
                        initialPlaceX = 7;
                        break;
                    case 'H':
                        initialPlaceX = 8;
                        break;
                }
                if (initialPlaceX == 0)
                {
                    wrong++;
                }
                string numbers = "123456789";
                initialPlaceY = numbers.IndexOf(input[1] + "") + 1;
                if (initialPlaceY == -1)
                {
                    wrong++;
                }


                switch (input[2])
                {
                    case 'a':
                        chosenPlaceX = 1;
                        break;
                    case 'b':
                        chosenPlaceX = 2;
                        break;
                    case 'c':
                        chosenPlaceX = 3;
                        break;
                    case 'd':
                        chosenPlaceX = 4;
                        break;
                    case 'e':
                        chosenPlaceX = 5;
                        break;
                    case 'f':
                        chosenPlaceX = 6;
                        break;
                    case 'g':
                        chosenPlaceX = 7;
                        break;
                    case 'h':
                        chosenPlaceX = 8;
                        break;
                }
                if (chosenPlaceX == 0)
                {
                    wrong++;
                }
                chosenPlaceY = numbers.IndexOf(input[3] + "") + 1;
                if (chosenPlaceY == -1)
                {
                    wrong++;
                }
            } while (wrong > 0);
            /* need to check if its needed
            if (initialPlaceX > 8 || initialPlaceX < 1 || initialPlaceY > 8 || initialPlaceY < 1 || chosenPlaceX > 8 || chosenPlaceX < 1 || chosenPlaceX > 8 || chosenPlaceX < 1)
            {
                Console.WriteLine("This square is not in board");
                choosingAct();
            }*/
            if (board[initialPlaceX, initialPlaceY] != null && board[initialPlaceX, initialPlaceY].getIsWhite()) // this is white tool. user cant enter null place as initial
            {
                if (countSteps % 2 ==0) // its the white turn
                {
                    if (board[initialPlaceX, initialPlaceY].go(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, countSteps, checkIfChosenPlaceIsEmpty(chosenPlaceX, chosenPlaceY))) // checking if step is valid according to each tool
                    {
                        if (checkIfRowIsFree(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, board[initialPlaceX, initialPlaceY].getNmae()) && (checkIfColumnIsFree(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, board[initialPlaceX, initialPlaceY].getNmae()))) // ensure that there is no tools between initial row and chosen
                        {
                            if (board[chosenPlaceX, chosenPlaceY] != null && !(board[chosenPlaceX, chosenPlaceY].getIsWhite())) // the chosen place is not empty, but with negative color tool
                            {
                                if (!(ToolIsUnderThreat(findXLocationOfKing(true), findYLocationOfKing(true), true, chosenPlaceX, chosenPlaceY))) // there is no threat on white king
                                    setChosenPlace(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY);
                                else
                                    Console.WriteLine("white king is in danger!");
                            }
                            else if (board[chosenPlaceX, chosenPlaceY] == null)
                            {
                                if (!(ToolIsUnderThreat(findXLocationOfKing(true), findYLocationOfKing(true), true, chosenPlaceX, chosenPlaceY))) // there is no threat on white king
                                    setChosenPlace(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY);
                                else
                                    Console.WriteLine("white king is in danger!");
                            }
                            else
                            {
                                Console.WriteLine("you can not pass on your own tools! \n");
                            }
                            if ((board[chosenPlaceX, chosenPlaceY].getNmae() == "WhitePawn") && (chosenPlaceY == 1)) // white pawn reach the first line of black and get new rule
                            {
                                bool isValid = true;
                                do
                                {
                                    Console.WriteLine("which tool do you choose for the pawn? (QUEEN / BISHOP / ROOK / KNIGHT)?");
                                    Console.WriteLine("choose and press ENTER");
                                    string choiceNewRuleForPawn = Console.ReadLine();
                                    switch (choiceNewRuleForPawn)
                                    {
                                        case "QUEEN":
                                            board[chosenPlaceX, chosenPlaceY] = new Queen("WhiteQueen", true);
                                            isValid = true;
                                            break;
                                        case "BISHOP":
                                            board[chosenPlaceX, chosenPlaceY] = new Bishop("WhiteBishop", true);
                                            isValid = true;
                                            break;
                                        case "ROOK":
                                            board[chosenPlaceX, chosenPlaceY] = new Rook("WhiteRook", true);
                                            isValid = true;
                                            break;
                                        case "KNIGHT":
                                            board[chosenPlaceX, chosenPlaceY] = new Knight("WhiteKnight", true);
                                            isValid = true;
                                            break;
                                        default:
                                            Console.WriteLine("enter a valid name of tool");
                                            isValid = false;
                                            break;
                                    }
                                } while (!isValid);
                            }
                        }
                        else
                            Console.WriteLine("sorry, there is tool in your way");
                    }
                    else
                    {
                        Console.WriteLine("this tool is not permitted to do such act\n");
                        choosingAct();
                    }
                }
            }
            else if (board[initialPlaceX, initialPlaceY] != null) // this is black tool, user cant enter null place
            {
                if (countSteps % 2 == 1) // its the black turn
                {
                    if (board[initialPlaceX, initialPlaceY].go(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, countSteps, checkIfChosenPlaceIsEmpty(chosenPlaceX, chosenPlaceY))) // checking if step is valid according to each tool
                    {
                        if (checkIfRowIsFree(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, board[initialPlaceX, initialPlaceY].getNmae()) && (checkIfColumnIsFree(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, board[initialPlaceX, initialPlaceY].getNmae()))) // ensure that there is no tools between initial row and chosen
                        {
                            if (board[chosenPlaceX, chosenPlaceY] != null && board[chosenPlaceX, chosenPlaceY].getIsWhite()) // the chosen place is white, so the tool can go
                            {
                                if (!(ToolIsUnderThreat(findXLocationOfKing(false), findYLocationOfKing(false), false))) // there is no threat on black king
                                {
                                    setChosenPlace(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY); // place was settled
                                }
                            }
                            else if (board[chosenPlaceX, chosenPlaceY] == null)
                            {
                                if (!(ToolIsUnderThreat(findXLocationOfKing(false), findYLocationOfKing(false), false))) // there is no threat on black king
                                {
                                    setChosenPlace(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY); // place was settled
                                }
                            }
                            else
                            {
                                Console.WriteLine("you can not pass on your own tools!");
                            }
                            if ((board[chosenPlaceX, chosenPlaceY].getNmae() == "BlackPawn") && (chosenPlaceY == 8)) // black pawn reach the first line of white and get new rule
                            {
                                bool isValid = true;
                                do
                                {
                                    Console.WriteLine("which tool do you choose for the pawn? (QUEEN / BISHOP / ROOK / KNIGHT)?");
                                    Console.WriteLine("choose and press ENTER");
                                    string choiceNewRuleForPawn = Console.ReadLine();
                                    switch (choiceNewRuleForPawn)
                                    {
                                        case "QUEEN":
                                            board[chosenPlaceX, chosenPlaceY] = new Queen("BlackQueen", false);
                                            isValid = true;
                                            break;
                                        case "BISHOP":
                                            board[chosenPlaceX, chosenPlaceY] = new Bishop("BlackBishop", false);
                                            isValid = true;
                                            break;
                                        case "ROOK":
                                            board[chosenPlaceX, chosenPlaceY] = new Rook("BlackRook", false);
                                            isValid = true;
                                            break;
                                        case "KNIGHT":
                                            board[chosenPlaceX, chosenPlaceY] = new Knight("BlackKnight", false);
                                            isValid = true;
                                            break;
                                        default:
                                            Console.WriteLine("enter a valid name of tool");
                                            isValid = false;
                                            break;
                                    }
                                } while (!isValid);
                            }
                        }
                        else
                            Console.WriteLine("sorry, there is tool in your way");
                    }
                    else
                    {
                        Console.WriteLine("this tool is not permitted to do such act\n");
                        choosingAct();
                    }
                }
            }
            else // its null place
            {
                Console.WriteLine("you entered empty place ant not tool. try again");
                choosingAct();
            }

        }
        public bool checkIfChosenPlaceIsEmpty(int chosenPlaceX, int chosenPlaceY)
        {
            if (board[chosenPlaceX, chosenPlaceY] == null)
                return true;
            return false;
        }
        public void setChosenPlace(int initialPlaceX, int initialPlaceY, int chosenPlaceX, int chosenPlaceY)
        {
            board[chosenPlaceX, chosenPlaceY] = board[initialPlaceX, initialPlaceY]; // new place was settled
            board[initialPlaceX, initialPlaceY] = null; // place was left
            countSteps++;
        }
        public bool checkIfRowIsFree(int initialPlaceX, int initialPlaceY, int chosenPlaceX, int chosenPlaceY, string toolName) // function that ensure free row between initial place to chosen place... good for queen, rook,
        {
            bool isFree = true;
            if ((chosenPlaceX - initialPlaceX == 1) || (initialPlaceX - chosenPlaceX == 1)) // tool want to move only one place in row, then there's no need of function
                return true;

            if (toolName == "WhiteKing" || toolName == "WhiteKnight" || toolName == "WhitePawn" || toolName == "BlackKing" || toolName == "BlackKnight" || toolName == "BlackPawn") // tools that dont need this check
                return true;
            if (toolName == "WhiteBishop" || toolName == "BlackBishop" || toolName == "WhiteQueen" || toolName == "BlackQueen")
            {
                isFree = checkIfDiagonalIsFree(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, toolName); // special function for bishop
            }

            else if (chosenPlaceX > initialPlaceX) // move to right
            {
                for (int i = initialPlaceX + 1; i < chosenPlaceX; i++)
                {
                    if (board[i, initialPlaceY] != null)
                        isFree = false;
                }
            }
            else if (initialPlaceX > chosenPlaceX) // move to left
            {
                for (int i = initialPlaceX - 1; i > chosenPlaceX; i--)
                {
                    if (board[i, initialPlaceY] != null)
                        isFree = false;
                }
            }
            return isFree;         
        }
        public bool checkIfColumnIsFree(int initialPlaceX, int initialPlaceY, int chosenPlaceX, int chosenPlaceY, string toolName) // function that ensure free column between initial place to chosen place... good for queen, rook, 
        {
            bool isFree = true;
            if ((chosenPlaceY - initialPlaceY == 1) || (initialPlaceY - chosenPlaceY == 1)) // tool want to move only one place in column, then there's no need of function
                return true;

            if (toolName == "WhiteKing" || toolName == "WhiteKnight" || toolName == "WhitePawn" || toolName == "BlackKing" || toolName == "BlackKnight" || toolName == "BlackPawn") // tools that dont need this check
                return true;
            if (toolName == "WhiteBishop" || toolName == "BlackBishop" || toolName == "WhiteQueen" || toolName == "BlackQueen")
            {
                isFree = checkIfDiagonalIsFree(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY, toolName) ; // special function for bishop 
            }

            else if (chosenPlaceY > initialPlaceY) // move down
            {
                for (int i = initialPlaceY + 1; i < chosenPlaceY; i++)
                {
                    if (board[initialPlaceX, i] != null)
                        isFree = false;
                }
            }
            else if (initialPlaceY > chosenPlaceY) // move up
            {
                for (int i = initialPlaceY - 1; i > chosenPlaceY; i--)
                {
                    if (board[initialPlaceX, i] != null)
                        isFree = false;
                }
            }
            return isFree;
        }
        public bool checkIfDiagonalIsFree(int initialPlaceX, int initialPlaceY, int chosenPlaceX, int chosenPlaceY, string toolName)
        {
            bool isFree = true;
            string resultOfQueenMove = "";
            if (chosenPlaceX - initialPlaceX == 1)
                return isFree; // it moves only one step

            if (toolName == "BlackQueen" || toolName == "WhiteQueen")
            {
                resultOfQueenMove = checkIfRowAndColumnAreFreeForQueen(initialPlaceX, initialPlaceY, chosenPlaceX, chosenPlaceY); // check if queen move on row or column
                if (resultOfQueenMove == "queen jump on tool")
                {
                    isFree = false;
                    return isFree;
                }
            }

            if (toolName == "BlackBishop" || toolName == "WhiteBishop" || resultOfQueenMove == "")
            {
                if (chosenPlaceX > initialPlaceX && chosenPlaceY < initialPlaceY) // bishop or queen go up right
                {
                    for (int i = initialPlaceX + 1; i < chosenPlaceX; i++) 
                    {
                        int j = initialPlaceX + initialPlaceY - i;
                        if (board[i, j] != null)
                            isFree = false;
                    }
                }
                else if (chosenPlaceX < initialPlaceX && chosenPlaceY < initialPlaceY) // bishop or queen go up left
                {
                    for (int i = initialPlaceX - 1; i > chosenPlaceX; i--)
                    {
                        int j = initialPlaceY - initialPlaceX + i;
                        if (board[i, j] != null)
                            isFree = false;
                    }
                }
                else if (chosenPlaceX > initialPlaceX && chosenPlaceY > initialPlaceY) // bishop or queen go down right
                {
                    for (int i = initialPlaceX + 1; i < chosenPlaceX; i++)
                    {
                        int j = initialPlaceY - initialPlaceX + i;
                        if (board[i, j] != null)
                            isFree = false;
                    }
                }
                else if (chosenPlaceX < initialPlaceX && chosenPlaceY > initialPlaceY) // bishop or queen go down left
                {
                    for (int i = initialPlaceX - 1; i > chosenPlaceX; i--)
                    {
                        int j = initialPlaceX + initialPlaceY - i;
                        if (board[i, j] != null)
                            isFree = false;
                    }
                }

            }
            return isFree; 
        }

        public string checkIfRowAndColumnAreFreeForQueen(int initialPlaceX, int initialPlaceY, int chosenPlaceX, int chosenPlaceY)
        {
            string resultOfQueenMove = "";
            if ((chosenPlaceY > initialPlaceY) && (chosenPlaceX == initialPlaceX)) // queen move down
            {
                for (int i = initialPlaceY + 1; i < chosenPlaceY; i++)
                {
                    if (board[initialPlaceX, i] != null)
                        resultOfQueenMove += "queen jump on tool";
                }
            }
            else if ((initialPlaceY > chosenPlaceY) && (chosenPlaceX == initialPlaceX)) // queen move up
            {
                for (int i = initialPlaceY - 1; i > chosenPlaceY; i--)
                {
                    if (board[initialPlaceX, i] != null)
                        resultOfQueenMove += "queen jump on tool";
                }
            }
            else if ((chosenPlaceX > initialPlaceX) && (chosenPlaceY == initialPlaceY)) // queen move to right
            {
                for (int i = initialPlaceX + 1; i < chosenPlaceX; i++)
                {
                    if (board[i, initialPlaceY] != null)
                        resultOfQueenMove += "queen jump on tool";
                }
            }
            else if ((initialPlaceX > chosenPlaceX) && (chosenPlaceY == initialPlaceY)) // queen move to left
            {
                for (int i = initialPlaceX - 1; i > chosenPlaceX; i--)
                {
                    if (board[i, initialPlaceY] != null)
                        resultOfQueenMove += "queen jump on tool";
                }
            }
            return resultOfQueenMove;

        }
        public int findXLocationOfKing(bool type) // a function that finda the x location of king
        {
            if (type) // its white tool
            {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (board[i ,j] != null)
                        {
                            if (board[i, j].getNmae() == "WhiteKing")
                            {
                                return i;
                            }
                        }
                    }
                }
                return 1000;  // its a sign of the death of white king
            }
            else  // its black tool
            {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (board[i, j] != null)
                        {
                            if (board[i, j].getNmae() == "BlackKing")
                            {
                                return i;
                            }
                        }
                    }
                }
                return 2000; // its a sign of the death of black king
            }
        }

        public int findYLocationOfKing(bool type) // a function that finda the x location of king
        {
            if (type) // its white tool
            {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (board[j, i] != null)
                        {
                            if (board[j, i].getNmae() == "WhiteKing")
                                return i;
                        }
                    }
                }
                return 1000; // its a sign of the death of white king
            }
            else // its black tool
            {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (board[j, i] != null)
                        {
                            if (board[j, i].getNmae() == "BlackKing")
                            return i;
                        }
                    }
                }
                return 2000; // its a sign of the death of black king
            }
        }

        public bool ToolIsUnderThreat(int placeX, int placeY, bool type)
        {

            if (type) // its white tool
            {


                // looking for threat on up left
                for (int i = placeX - 1; i > 0; i--) 
                {
                    int j = placeY - placeX + i;
                    if (j > 0)
                    {
                        if ((board[i, j] != null) && board[i, j].getNmae() == "BlackQueen" || (board[i, j] != null) && board[i, j].getNmae() == "BlackBishop")
                            return true;
                    }
                }

                // looking for threat on up right
                for (int i = placeX + 1; i < 9; i++) 
                {
                    int j = placeY + placeX - i;
                    if (j > 0)
                    {
                        if ((board[i, j] != null) && board[i, j].getNmae() == "BlackQueen" || (board[i, j] != null) && board[i, j].getNmae() == "BlackBishop")
                            return true;
                    }
                }

                // looking for threat on down right
                for (int i = placeX + 1; i < 9; i++) 
                {
                    int j = placeY - placeX + i;
                    if (j < 9)
                    {
                        if ((board[i, j] != null) && board[i, j].getNmae() == "BlackQueen" || (board[i, j] != null) && board[i, j].getNmae() == "BlackBishop")
                            return true;
                    }
                }

                // looking for threat on down left
                for (int i = placeX + 1; i > 0; i--) 
                {
                    int j = placeY + placeX - i;
                    if (j < 9)
                    {
                        if ((board[i, j] != null) && board[i, j].getNmae() == "BlackQueen" || (board[i, j] != null) && board[i, j].getNmae() == "BlackBishop")
                            return true;
                    }
                }

                // looking for threat on right row
                for (int i = placeX + 1; i < 9; i++)
                {
                    int j = placeY;
                    if (board[i, j] != null)
                    {
                        if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                            return true;
                    }
                }

                // looking for threat on left row
                for (int i = placeX - 1; i > 0; i--)
                {
                    int j = placeY;
                    if (board[i, j] != null)
                    {
                        if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                            return true;
                    }
                }

                // looking for threat on up column
                for (int j = placeY - 1; j > 0; j--)
                {
                    int i = placeX;
                    if (board[i, j] != null)
                    {
                        if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                            return true;
                    }
                }

                // looking for threat on down column
                for (int j = placeY + 1; j < 9; j++)
                {
                    int i = placeX;
                    if (board[i, j] != null)
                    {
                        if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                            return true;
                    }
                }

                // looking for threat from black knight
                if ((placeX + 1 < 9) && (placeY + 2 < 9) && (board[placeX + 1, placeY + 2] != null)) // option 1 of 8
                    if (board[placeX + 1, placeY + 2].getNmae() == "BlackKnight")
                        return true;

                if ((placeX + 2 < 9) && (placeY + 1 < 9) && (board[placeX + 2, placeY + 1] != null)) // option 2 of 8
                    if (board[placeX + 2, placeY + 1].getNmae() == "BlackKnight")
                        return true;

                if ((placeX + 2 < 9) && (placeY - 1 > 0) && (board[placeX + 2, placeY - 1] != null)) // option 3 of 8
                    if (board[placeX + 2, placeY - 1].getNmae() == "BlackKnight")
                        return true;

                if ((placeX + 1 < 9) && (placeY -2 > 0) && (board[placeX + 1, placeY - 2] != null)) // option 4 of 8
                    if (board[placeX + 1, placeY - 2].getNmae() == "BlackKnight")
                        return true;

                if ((placeX - 1 > 0) && (placeY - 2 > 0) && (board[placeX - 1, placeY - 2] != null)) // option 5 of 8
                    if (board[placeX - 1, placeY - 2].getNmae() == "BlackKnight")
                        return true;

                if ((placeX - 2 > 0) && (placeY - 1 > 0) && (board[placeX - 2, placeY - 1] != null)) // option 6 of 8
                    if (board[placeX - 2, placeY - 1].getNmae() == "BlackKnight")
                        return true;

                if ((placeX - 2 > 0) && (placeY + 1 < 9) && (board[placeX - 2, placeY + 1] != null)) // option 7 of 8
                    if (board[placeX - 2, placeY + 1].getNmae() == "BlackKnight")
                        return true;

                if ((placeX - 1 > 0) && (placeY + 2 < 9) && (board[placeX - 1, placeY + 2] != null)) // option 8 of 8
                    if (board[placeX - 1, placeY + 2].getNmae() == "BlackKnight")
                        return true;

                /*
                int i = placeX; // looking for threat in down right location
                int j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && (j < 9) && board[i, j] == null)
                {
                    i++;
                    j++;
                }

                if (board[i, j].getNmae() == "BlackQueen" || board[i, j].getNmae() == "BlackBishop")

                {
                    return true;
                }
                i = placeX; // looking for threat in up right location
                j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    i++;
                    j--;
                }
                if (board[i, j].getNmae() == "BlackQueen" || board[i, j].getNmae() == "BlackBishop")
                {
                    return true;
                }
                i = placeX; // looking for threat in up left location
                j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    i--;
                    j--;
                }
                if (board[i, j].getNmae() == "BlackQueen" || board[i, j].getNmae() == "BlackBishop")
                {
                    return true;
                }
                i = placeX; // looking for threat in down left location
                j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    i--;
                    j++;
                }
                if (board[i, j].getNmae() == "BlackQueen" || board[i, j].getNmae() == "BlackBishop")
                {
                    return true;
                }

                i = placeX; // looking for threat in right row
                j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    i++;
                }
                if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                {
                    return true;
                }
                i = placeX;
                j = placeY;
                // looking for threat in left row
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    i--;
                }
                if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                {
                    return true;
                }

                i = placeX; // looking for threat in up column
                j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    j--;
                }
                if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                {
                    return true;
                }
                i = placeX; // looking for threat in down column
                j = placeY;
                while ((i > 0) && (i < 9) && (j > 0) && board[i, j] == null)
                {
                    j++;
                }
                if (board[i, j].getNmae() == "BlackRook" || board[i, j].getNmae() == "BlackQueen")
                {
                    return true;
                }
                */


            }
            return false;

                /*
                
                i = placeX;
                j = placeY;

                
                if (board[i + 1, j + 2].getNmae() == "BlackKnight" || board[i + 2, j + 1].getNmae() == "BlackKnight" || board[i + 2, j - 1].getNmae() == "BlackKnight"
                    || board[i + 1, j - 2].getNmae() == "BlackKnight" || board[i - 1, j - 2].getNmae() == "BlackKnight" || board[i - 2, j - 1].getNmae() == "BlackKnight" || board[i - 2, j + 1].getNmae() == "BlackKnight" || board[i - 1, j + 2].getNmae() == "BlackKnight") // black knight is threating
                    return true;
                else if (board[i + 1, j - 1].getNmae() == "BlackPawn" || board[i - 1, j - 1].getNmae() == "BlackPawn") // black pawn is threatin
                    return true;
                else if (board[i + 1, j - 1].getNmae() == "BlackKing" || board[i, j - 1].getNmae() == "BlackKing" || board[i - 1, j - 1].getNmae() == "BlackKing" || board[i - 1, j].getNmae() == "BlackKing"
                    || board[i - 1, j + 1].getNmae() == "BlackKing" || board[i, j + 1].getNmae() == "BlackKing" || board[i + 1, j + 1].getNmae() == "BlackKing" || board[i + 1, j].getNmae() == "BlackKing") // black king is threating
                    return true;


                return false;
              

            } 

            
            
            else // its black tool
            {
                int i = placeX + 1; // looking for threat in down right location
                int j = placeY + 1;
                while (board[i, j] == null)
                {
                    i++;
                    j++;
                }
                if (board[i, j].getNmae() == "WhiteQueen" || board[i, j].getNmae() == "WhiteBishop")
                {
                    return true;
                }
                i = placeX + 1; // looking for threat in up right location
                j = placeY - 1;
                while (board[i, j] == null)
                {
                    i++;
                    j--;
                }
                if (board[i, j].getNmae() == "WhiteQueen" || board[i, j].getNmae() == "WhiteBishop")
                {
                    return true;
                }
                i = placeX - 1; // looking for threat in up left location
                j = placeY - 1;
                while (board[i, j] == null)
                {
                    i--;
                    j--;
                }
                if (board[i, j].getNmae() == "WhiteQueen" || board[i, j].getNmae() == "WhiteBishop")
                {
                    return true;
                }
                i = placeX - 1; // looking for threat in down left location
                j = placeY + 1;
                while (board[i, j] == null)
                {
                    i--;
                    j++;
                }
                if (board[i, j].getNmae() == "WhiteQueen" || board[i, j].getNmae() == "WhiteBishop")
                {
                    return true;
                }

                i = placeX + 1; // looking for threat in right row
                j = placeY;
                while (board[i, j] == null)
                {
                    i++;
                }
                if (board[i, j].getNmae() == "WhiteRook" || board[i, j].getNmae() == "WhiteQueen")
                {
                    return true;
                }
                i = placeX - 1; // looking for threat in left row
                while (board[i, j] == null)
                {
                    i--;
                }
                if (board[i, j].getNmae() == "WhiteRook" || board[i, j].getNmae() == "WhiteQueen")
                {
                    return true;
                }

                i = placeX; // looking for threat in up column
                j = placeY - 1;
                while (board[i, j] == null)
                {
                    j--;
                }
                if (board[i, j].getNmae() == "WhiteRook" || board[i, j].getNmae() == "WhiteQueen")
                {
                    return true;
                }
                i = placeX; // looking for threat in down column
                j = placeY + 1;
                while (board[i, j] == null)
                {
                    j++;
                }
                if (board[i, j].getNmae() == "WhiteRook" || board[i, j].getNmae() == "WhiteQueen")
                {
                    return true;
                }
                i = placeX;
                j = placeY;
                if (board[i + 1, j + 2].getNmae() == "WhiteKnight" || board[i + 2, j + 1].getNmae() == "WhiteKnight" || board[i + 2, j - 1].getNmae() == "WhiteKnight"
                    || board[i + 1, j - 2].getNmae() == "WhiteKnight" || board[i - 1, j - 2].getNmae() == "WhiteKnight" || board[i - 2, j - 1].getNmae() == "WhiteKnight" || board[i - 2, j + 1].getNmae() == "WhiteKnight" || board[i - 1, j + 2].getNmae() == "WhiteKnight") // white knight is threating
                    return true;
                else if (board[i + 1, j + 1].getNmae() == "WhitePawn" || board[i - 1, j + 1].getNmae() == "WhitePawn") // white pawn is threatin
                    return true;
                else if (board[i + 1, j - 1].getNmae() == "WhiteKing" || board[i, j - 1].getNmae() == "WhiteKing" || board[i - 1, j - 1].getNmae() == "WhiteKing" || board[i - 1, j].getNmae() == "WhiteKing"
                    || board[i - 1, j + 1].getNmae() == "WhiteKing" || board[i, j + 1].getNmae() == "WhiteKing" || board[i + 1, j + 1].getNmae() == "WhiteKing" || board[i + 1, j].getNmae() == "WhiteKing") // white king is threating
                    return true;
                else
                {
                    Console.WriteLine("black king is threaten");
                    return false;
                }
                
            }*/
           
        }


        /*public bool checkIfColumnIsFree(int initialPlaceX, int initialPlaceY, int chosenPlaceX, int chosenPlaceY) // function that ensure free column between initial place to chosen place
        {
            if (chosenPlaceY > initialPlaceY) // move down
            {
                for (int i = initialPlaceY + 1; i < chosenPlaceY; i++)
                {
                    if ()
                }
            }

        }*/
    }
}
