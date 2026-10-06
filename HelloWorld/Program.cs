namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GAME VARIABLES //
            bool running = false;
            bool is_game_over = false;
            int score_to_win = 5;
            string player_input = "";
            //int player_lives = 3; TODO: Implement lives system

            int player_score = 0;
            int opponent_score = 0;

            int player_number = 0;
            int opponent_number = 0;

            // GAME FUNCTIONS //
            static int generate_opponent_number()
            {
                Random random = new Random();
                return random.Next(1, 10);
            }

            // GAME ARRAYS //
            string[] messages = {
                "Would you like to play the game? Type yes or no.",
                "\nWelcome to the Guessing Game, you must guess your opponents number between the numbers 1 and 10. Guess Correct to earn points. First to 5 points wins! \n",
                "\nGoodbye!",
                "\nYou are now playing The Game. Guess your opponents number to win!",
                "\nEnter:",
                "\nYou win!",
                "\nYou lose!",
                "\nYour score is: ",
                "\nYour opponents score is: ",
                "\nYou beat the Opponent! Congratulations!",
                "\nYou lost to the Opponent! Better luck next time!",
            };

            string[] decision = {
                "yes",
                "no",
            };

            // THE GAME LOOP //
            Console.WriteLine(messages[0]);
            player_input = Console.ReadLine().ToLower();

            if (player_input == decision[0])
            {
                running = true;
                Console.WriteLine(messages[1]);
            }
            else if (player_input == decision[1])
            {
                running = false;
                Console.WriteLine(messages[2]);
            }

            while (running == true)
            {
                if (player_score < score_to_win)
                {
                    opponent_number = generate_opponent_number();

                    Console.WriteLine(messages[3]);
                    player_number = Convert.ToInt32(Console.ReadLine());

                    if (player_number == opponent_number)
                    {
                        player_score++;
                        Console.WriteLine(messages[5]);
                        Console.WriteLine(messages[7] + Convert.ToString(player_score));
                        Console.WriteLine(messages[8] + Convert.ToString(opponent_score));
                    }
                    else
                    {
                        opponent_score++;
                        Console.WriteLine(messages[6]);
                        Console.WriteLine(messages[7] + Convert.ToString(player_score));
                        Console.WriteLine(messages[8] + Convert.ToString(opponent_score));
                        if (opponent_score == score_to_win)
                        {
                            Console.WriteLine(messages[10]);
                            running = false;
                        }
                    }
                } else
                {
                    running = false;
                    Console.WriteLine(messages[5]);
                    Console.WriteLine(messages[9]);

                }
            }
        }
    }
}
