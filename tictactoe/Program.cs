using System;
using gBoard;

namespace MainGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] untakenPiece = new int[] {1,2,3,4,5,6,7,8,9};
            bool isPlayerX = true;
            Board gameboard = new Board();
            char winner;
            for(int i=0;i<9;i++)
            {
                if(i>=5)
                {
                    winner = gameboard.findWinner();
                    switch (winner)
                    {
                        case 'X':
                            Console.WriteLine(gameboard.ToString());
                            Console.WriteLine("{0} has won", winner);
                            return;
                        case 'O':
                            Console.WriteLine(gameboard.ToString());
                            Console.WriteLine("{0} has won", winner);
                            return;
                        case 'U':
                            break;
                        default: 
                            break;
                    }
                }
                Console.WriteLine(gameboard.ToString());
                int tempnum = 0;
                if(isPlayerX)
                {
                    Console.Write(" enter number : ");
                    int.TryParse(Console.ReadLine(), out tempnum);

                    if(tempnum >=1 && tempnum <=9 && untakenPiece.Contains(tempnum))
                    {
                        untakenPiece = untakenPiece.Where(val => val != tempnum).ToArray();
                        gameboard.TakePiece(tempnum, "X");
                        isPlayerX = !isPlayerX;
                    }
                    else 
                    {
                        Console.WriteLine("invalid input");
                        i--;
                    }
                }
                else 
                {
                    Console.Write(" enter number : ");
                    int.TryParse(Console.ReadLine(), out tempnum);

                    if(tempnum >=1 && tempnum <=9 && untakenPiece.Contains(tempnum))
                    {
                        untakenPiece = untakenPiece.Where(val => val != tempnum).ToArray();
                        gameboard.TakePiece(tempnum, "O");
                        isPlayerX = !isPlayerX;
                    }
                    else 
                    {
                        Console.WriteLine("invalid input");
                        i--;
                    }
                }
            }

        }
    }
}