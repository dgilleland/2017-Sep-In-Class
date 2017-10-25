/* Stock Picker
 * based on the old board game "Stock Ticker"
 * see https://en.wikipedia.org/wiki/Stock_Ticker
 */
using System;

namespace StockPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables for the game
            const string GOLD = "Gold", SILVER = "Silver", BONDS = "Bonds",
                   OIL = "Oil", INDUSTRIALS = "Industrials", GRAIN = "Grain";
            double goldPrice, silverPrice, bondsPrice, oilPrice, industrialsPrice, grainPrice;
            string stock;
            double amount = 0;
            // All prices start at $1.00
            goldPrice = silverPrice = bondsPrice = oilPrice = industrialsPrice = grainPrice = 1.00;
            // Die variables
            Random rnd = new Random();
            int stockDie, changeDie, amountDie;
            // Constants for responding to die rolls and player choices
            const int GOLD_ROLL = 1, SILVER_ROLL = 2, BONDS_ROLL = 3,
                      OIL_ROLL = 4, INDUSTRIALS_ROLL = 5, GRAIN_ROLL = 6;
            const int STOCK_DIVIDEND = 0, STOCK_UP = 1, STOCK_DOWN = 2;
            const int GROUP_500 = 500, GROUP_1000 = 1000, GROUP_2000 = 2000, GROUP_5000 = 5000;
            const double AMOUNT_5 = .05, AMOUNT_10 = .10, AMOUNT_20 = .20;
            // Player information
            string name;
            int goldCount, silverCount, bondsCount, oilCount, industrialsCount, grainCount;
            goldCount = silverCount = bondsCount = oilCount = industrialsCount = grainCount = 0;
            double cash = 5000.00; // Player starts with $5000.00

            // Gather user info
            Console.WriteLine("S.T.O.C.K. . .P.I.C.K.E.R...");
            Console.WriteLine("----------------------------");

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("----------------------------\nRULES\n");

            Console.WriteLine("The game has six stocks, which in fact are commodities. These six are gold, silver, bonds, oil, industrials, and grain. During gameplay all the stocks are identical. Each stock begins costing a dollar apiece. Players are given starting money of $5000 and they buy shares in groups of 500, 1000, 2000, or 5000. The stocks move based on the throw of three dice. The first die picks the stock that will be affected, with one of the commodities on each side of the die. The second die determines what whether the stock will move up, down, or pay a dividend. The third die decides if the movement or dividend will be five, ten, or twenty cents. For instance a roll of Industrials, Down, 20 will move the industrials stock from its start value of $1.00 to 80 cents. A roll of Grain, Up, 5 would move grain up to $1.05.\n");

            Console.WriteLine("Dividends are paid out only for any stocks that are at or above $1.00 in value.For instance, a five cent dividend pays five cents for each share owned.Thus if a roll is Oil, Dividend, 10, and you own a thousand shares of Oil at $1.25 apiece you will receive a dividend of $100.Note that the dividend is not affected by the value of the share, with only the rule being that stocks worth less than $1.00 do not pay out when a dividend is rolled for them.\n");
            Console.WriteLine("----------------------------\n");

            // Perform 10 turns
            int turnNumber = 0;
            do
            {
                // Phase 1: Purchase Stocks
                // Priming read
                int userChoice;
                do
                {
                    Console.WriteLine("Stocks:");
                    Console.WriteLine($"\t1) {GOLD}");
                    Console.WriteLine($"\t2) {SILVER}");
                    Console.WriteLine($"\t3) {BONDS}");
                    Console.WriteLine($"\t4) {OIL}");
                    Console.WriteLine($"\t5) {INDUSTRIALS}");
                    Console.WriteLine($"\t6) {GRAIN}");
                    Console.Write($"You have {cash:C}. Choose a stock to buy (0 to skip): ");
                    while (!int.TryParse(Console.ReadLine(), out userChoice) ||
                          (userChoice < 0 || userChoice > 6))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Invalid choice! Enter a number from 0 to 6: ");
                        Console.ResetColor();
                    }
                    if (userChoice > 0)
                    {
                        double purchasePrice = 0;
                        int buyAmount = 0;
                        do
                            Console.Write("Enter either 500, 1000, 2000, or 5000: ");
                        while (!int.TryParse(Console.ReadLine(), out buyAmount) ||
                               (buyAmount != GROUP_500 &&
                                buyAmount != GROUP_1000 &&
                                buyAmount != GROUP_2000 &&
                                buyAmount != GROUP_5000));
                        switch (userChoice)
                        {
                            case 1:
                                purchasePrice = goldPrice;
                                break;
                            case 2:
                                purchasePrice = silverPrice;
                                break;
                            case 3:
                                purchasePrice = bondsPrice;
                                break;
                            case 4:
                                purchasePrice = oilPrice;
                                break;
                            case 5:
                                purchasePrice = industrialsPrice;
                                break;
                            case 6:
                                purchasePrice = grainPrice;
                                break;
                        }
                        if (purchasePrice * buyAmount > cash)
                            Console.WriteLine($"Sorry, you don't have enough cash to purchase {buyAmount} shares at {purchasePrice:C} each. You only have {cash:C}");
                        else
                        {
                            // Do the purchasing transaction
                            cash -= purchasePrice * buyAmount;
                            switch (userChoice)
                            {
                                case 1:
                                    goldCount += buyAmount;
                                    break;
                                case 2:
                                    silverCount += buyAmount;
                                    break;
                                case 3:
                                    bondsCount += buyAmount;
                                    break;
                                case 4:
                                    oilCount += buyAmount;
                                    break;
                                case 5:
                                    industrialsCount += buyAmount;
                                    break;
                                case 6:
                                    grainCount += buyAmount;
                                    break;
                            }
                        }
                    }
                } while (userChoice != 0 && cash >= 100);

                // Phase 2: Roll Die & Apply Changes
                stockDie = rnd.Next(1, 7); // Get a random number from 1 to 6
                changeDie = rnd.Next(3); // Get a random number from 0 to 2 (3 is the exclusive upper boundary)
                amountDie = rnd.Next(30000) % 3; // Increasing the range could increase randomness....

                // Determine which item is changing
                if (stockDie == GOLD_ROLL) stock = GOLD;
                else if (stockDie == SILVER_ROLL) stock = SILVER;
                else if (stockDie == BONDS_ROLL) stock = BONDS;
                else if (stockDie == OIL_ROLL) stock = OIL;
                else if (stockDie == INDUSTRIALS_ROLL) stock = INDUSTRIALS;
                else  stock = GRAIN;

                // Determine the amount that the item will change by
                if (amountDie == 0)
                    amount = AMOUNT_5;
                else if (amountDie == 1)
                    amount = AMOUNT_10;
                else if (amountDie == 2)
                    amount = AMOUNT_20;

                // Determine the type of change the occurs
                string changeType = "";
                switch(changeDie)
                {
                    case STOCK_DIVIDEND:
                        changeType = $"{stock} pays a dividend of {amount * 100}%.";
                        if (stockDie == GOLD_ROLL && goldPrice >= 1.00) cash += goldCount * amount;
                        if (stockDie == SILVER_ROLL && silverPrice >= 1.00) cash += silverCount * amount;
                        if (stockDie == BONDS_ROLL && bondsPrice >= 1.00) cash += bondsCount * amount;
                        if (stockDie == OIL_ROLL && oilPrice >= 1.00) cash += oilCount * amount;
                        if (stockDie == INDUSTRIALS_ROLL && industrialsPrice >= 1.00) cash += industrialsCount * amount;
                        if (stockDie == GRAIN_ROLL && grainPrice >= 1.00) cash += grainCount * amount;
                        break;
                    case STOCK_UP:
                        changeType = $"{stock} went up by {amount:C}";
                        if (stockDie == GOLD_ROLL) goldPrice += amount;
                        if (stockDie == SILVER_ROLL) silverPrice += amount;
                        if (stockDie == BONDS_ROLL) bondsPrice += amount;
                        if (stockDie == OIL_ROLL) oilPrice += amount;
                        if (stockDie == INDUSTRIALS_ROLL) industrialsPrice += amount;
                        if (stockDie == GRAIN_ROLL) grainPrice += amount;
                        break;
                    case STOCK_DOWN:
                        changeType = $"{stock} went down by {amount:C}";
                        if (stockDie == GOLD_ROLL) goldPrice -= amount;
                        if (stockDie == SILVER_ROLL) silverPrice -= amount;
                        if (stockDie == BONDS_ROLL) bondsPrice -= amount;
                        if (stockDie == OIL_ROLL) oilPrice -= amount;
                        if (stockDie == INDUSTRIALS_ROLL) industrialsPrice -= amount;
                        if (stockDie == GRAIN_ROLL) grainPrice -= amount;
                        break;
                }

                // TODO: Report the results of the die rolls and the stock prices
                Console.WriteLine("----------------------------\n");
                Console.WriteLine(changeType);
                Console.WriteLine($"Stocks: {GOLD,6} | {SILVER,6} | {BONDS,6} | {OIL,6} | {GRAIN,6} | {INDUSTRIALS,12}");
                Console.WriteLine($"Price:  {goldPrice,6:C} | {silverPrice,6:C} | {bondsPrice,6:C} | {oilPrice,6:C} | {grainPrice,6:C} | {industrialsPrice,12:C}");
                Console.WriteLine($"Shares: {goldCount,6} | {silverCount,6} | {bondsCount,6} | {oilCount,6} | {grainCount,6} | {industrialsCount,12}");
                Console.WriteLine($"You have {cash:C} in cash.");

                // Phase 3: Sell Stocks
                Console.WriteLine("----------------------------\n");
                Console.WriteLine("You can sell up to 3 stocks");
                for(int count = 0, stockChoice = 9; count < 3 && stockChoice > 0; count++)
                {
                    // Priming read
                    string stockName;
                    Console.WriteLine($"Stocks: {GOLD}, {SILVER}, {BONDS}, {OIL}, {GRAIN}, {INDUSTRIALS}");
                    Console.Write("Enter the name of a stock to sell (or just [ENTER] to quit): ");
                    stockName = Console.ReadLine();
                    while(!string.IsNullOrWhiteSpace(stockName) &&
                          stockName != GOLD && stockName != SILVER && stockName != BONDS &&
                          stockName != OIL && stockName != GRAIN && stockName != INDUSTRIALS)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Invalid choice! Enter the stock name: ");
                        Console.ResetColor();
                    }
                    if (string.IsNullOrWhiteSpace(stockName))
                        stockChoice = 0;
                    else
                    {
                        int sellAmount = 0;
                        do
                            Console.Write("Enter either 500, 1000, 2000, or 5000: ");
                        while (!int.TryParse(Console.ReadLine(), out sellAmount) ||
                               (sellAmount != GROUP_500 && 
                                sellAmount != GROUP_1000 && 
                                sellAmount != GROUP_2000 && 
                                sellAmount != GROUP_5000));
                        switch (stockName)
                        {
                            case GOLD:
                                if (goldCount < sellAmount) sellAmount = goldCount;
                                goldCount -= sellAmount;
                                cash += goldPrice * sellAmount;
                                break;
                            case SILVER:
                                if (silverCount < sellAmount) sellAmount = silverCount;
                                silverCount -= sellAmount;
                                cash += silverPrice * sellAmount;
                                break;
                            case BONDS:
                                if (bondsCount < sellAmount) sellAmount = bondsCount;
                                bondsCount -= sellAmount;
                                cash += bondsPrice * sellAmount;
                                break;
                            case OIL:
                                if (oilCount < sellAmount) sellAmount = oilCount;
                                oilCount -= sellAmount;
                                cash += oilPrice * sellAmount;
                                break;
                            case INDUSTRIALS:
                                if (industrialsCount < sellAmount) sellAmount = industrialsCount;
                                industrialsCount -= sellAmount;
                                cash += industrialsPrice * sellAmount;
                                break;
                            case GRAIN:
                                if (grainCount < sellAmount) sellAmount = grainCount;
                                grainCount -= sellAmount;
                                cash += grainPrice * sellAmount;
                                break;
                        }
                    }
                }
                Console.WriteLine("============================\n");
                turnNumber++;
            } while (turnNumber < 10);

            // Cash out all the stocks...
            cash += goldCount * goldPrice
                  + silverCount * silverPrice
                  + bondsCount + bondsPrice
                  + oilCount * oilPrice
                  + industrialsCount * industrialsPrice
                  + grainCount * grainPrice;

            Console.WriteLine($"{name}, you ended the game with {cash:C}");
        }
    }
}
