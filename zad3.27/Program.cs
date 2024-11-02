using System;

class Program
{
    static void Main()
    {
        char[,] board = {
            { '_', '_', '_' },
            { '_', '_', '_' },
            { '_', '_', '_' }
        };

        Console.Write("Nazwa gracza X: ");
        string playerX = Console.ReadLine();
        
        Console.Write("Nazwa gracza O: ");
        string playerO = Console.ReadLine();

        // Losowanie gracza rozpoczynającego
        Random rand = new Random();
        char currentPlayerSymbol = rand.Next(0, 2) == 0 ? 'X' : 'O';
        string currentPlayerName = currentPlayerSymbol == 'X' ? playerX : playerO;
        
        Console.WriteLine($"Rozpoczyna gracz: {currentPlayerName} ({currentPlayerSymbol})");

        int turns = 0;
        bool gameWon = false;

        while (!gameWon && turns < 9)
        {
            // Wyświetlanie planszy
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
            }
            Console.WriteLine();

            // Ruch gracza
            int row = -1, col = -1;
            bool validMove = false;

            while (!validMove)
            {
                Console.Write($"{currentPlayerName} ({currentPlayerSymbol}), podaj pozycję (np. 11 dla lewego górnego rogu): ");
                string position = Console.ReadLine();

                if (position.Length == 2 && int.TryParse(position[0].ToString(), out row) && int.TryParse(position[1].ToString(), out col))
                {
                    row--; // Konwersja do indeksu tablicy
                    col--;
                    validMove = row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == '_';

                    if (!validMove)
                        Console.WriteLine("Błędna pozycja lub pole już zajęte. Spróbuj ponownie.");
                }
                else
                {
                    Console.WriteLine("Niepoprawny format. Wpisz dwie cyfry, np. 11 dla lewego górnego rogu.");
                }
            }

            board[row, col] = currentPlayerSymbol;
            turns++;

            // Sprawdzanie wygranej
            gameWon = 
                (board[0, 0] == currentPlayerSymbol && board[0, 1] == currentPlayerSymbol && board[0, 2] == currentPlayerSymbol) || // Wiersz 1
                (board[1, 0] == currentPlayerSymbol && board[1, 1] == currentPlayerSymbol && board[1, 2] == currentPlayerSymbol) || // Wiersz 2
                (board[2, 0] == currentPlayerSymbol && board[2, 1] == currentPlayerSymbol && board[2, 2] == currentPlayerSymbol) || // Wiersz 3
                (board[0, 0] == currentPlayerSymbol && board[1, 0] == currentPlayerSymbol && board[2, 0] == currentPlayerSymbol) || // Kolumna 1
                (board[0, 1] == currentPlayerSymbol && board[1, 1] == currentPlayerSymbol && board[2, 1] == currentPlayerSymbol) || // Kolumna 2
                (board[0, 2] == currentPlayerSymbol && board[1, 2] == currentPlayerSymbol && board[2, 2] == currentPlayerSymbol) || // Kolumna 3
                (board[0, 0] == currentPlayerSymbol && board[1, 1] == currentPlayerSymbol && board[2, 2] == currentPlayerSymbol) || // Przekątna 1
                (board[0, 2] == currentPlayerSymbol && board[1, 1] == currentPlayerSymbol && board[2, 0] == currentPlayerSymbol);   // Przekątna 2

            if (!gameWon && turns < 9)
            {
                // Zmiana gracza
                if (currentPlayerSymbol == 'X')
                {
                    currentPlayerSymbol = 'O';
                    currentPlayerName = playerO;
                }
                else
                {
                    currentPlayerSymbol = 'X';
                    currentPlayerName = playerX;
                }
            }
        }

        // Wyświetlanie końcowego stanu planszy
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
        }
        Console.WriteLine();

        // Wyświetlanie wyniku gry
        if (gameWon)
            Console.WriteLine($"Wygrywa gracz {currentPlayerName} ({currentPlayerSymbol})!");
        else
            Console.WriteLine("Remis!");
    }
}
