using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Enter 1 to play the game");
                Console.WriteLine("Enter 2 to exit the game");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    bool gamRunning = true;
                    int score = 0;
                    Deck obj = new Deck();

                    obj.shuffle();
                    Card card1 = obj.dealCard();

                    while (gamRunning)
                    {
                        int remain_check = obj.cardsLeft();
                        Card card2 = obj.dealCard();
                        Console.WriteLine("******************************");
                        Console.WriteLine(card1.toString());
                        Console.WriteLine("");
                        Console.WriteLine("***Remaining Cards ***** : " + remain_check);
                        Console.WriteLine("Enter 1 if the next card is Higher.");
                        Console.WriteLine("Enter 2 if the next card is Lower.");

                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (card_check == 1)
                        {
                            if (card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gamRunning = false;
                                Console.WriteLine("SORRY YOU LOSE PRESS ANY TO CONTINUE.");
                                Console.WriteLine("The Card was: " + card2.toString());
                                Console.WriteLine("Your Score is: " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (card_check == 2) // for less than
                        {
                            if (card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gamRunning = false;
                                Console.WriteLine("SORRY YOU LOSE PRESS ANY TO CONTINUE.");
                                Console.WriteLine("The Card was: " + card2.toString());
                                Console.WriteLine("Your Score is: " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (obj.cardsLeft() == 0 && card2 == null)
                        {
                            gamRunning = false;
                            Console.WriteLine("Congrats you have scored maximum.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }
            } while (option != 2);
        }
    }
}
