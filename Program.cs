using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryCode;
            decimal  tileQuontiti, tilePrice;
            {
                const string COUNTRY_CODES =
                    "Азербаджан    (994)  |  Киргизия    (996)  |  Таджикистан    (992)\n" +
                    "Армения       (374)  |  Латвия      (371)  |  Туркмения      (993)\n" +
                    "Беларусь      (375)  |  Литва       (370)  |  Узбекистан     (998)\n" +
                    "Грузия        (995)  |  Молдова     (373)  |  Украина        (380)\n" +
                    "Казахстан     (007)  |  Россия      (007)  |  Эстония        (372)\n" +
                    "------------------------------------------------------------------";
                
                Console.WriteLine(COUNTRY_CODES);

                Console.WriteLine("Телефонный код страны: ");
                countryCode = Console.ReadLine(); 

                Console.Write("Количество плитки: ");
                string stringQuontiti = Console.ReadLine();
                tileQuontiti = Convert.ToDecimal(stringQuontiti);

                Console.Write("Цена за 1м. кв. плитки: ");
                string stringPrice = Console.ReadLine();
                tilePrice = Convert.ToDecimal(stringPrice);
            }

            decimal rate;
            {
                const string AZERBAIJANE_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                             GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007", KYRGYZSTANN_CODE = "996",
                             LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                             RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                             UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                if (countryCode == AZERBAIJANE_CODE)
                {
                    const decimal AZERBAIJANE_RATE = 1.07m;
                    rate = AZERBAIJANE_RATE;
                }
                else if (countryCode == ARMENIA_CODE)
                {
                    const decimal AMENIA_RATE = .95m;
                    rate= AMENIA_RATE;
                }
                else if (countryCode == BELARUS_CODE)
                {
                    const decimal BELARUS_RATE = 1;
                    rate = BELARUS_RATE;
                }
                else if (countryCode == GEORGIA_CODE)
                {
                    const decimal GEORGIA_RATE = 0.94m;
                    rate = GEORGIA_RATE;
                }
                else if (countryCode == KAZAKHSTAN_CODE)
                {
                    const decimal KAZAKHSTAN_RATE = 0.79m;
                    rate = KAZAKHSTAN_RATE;
                }
                else if (countryCode == KYRGYZSTANN_CODE)
                {
                    const decimal KYRGYZSTANN_RATE = 0.83m;
                    rate = KYRGYZSTANN_RATE;
                }
                else if (countryCode == LATVIA_CODE)
                {
                    const decimal LATVIA_RATE = 1.12m;
                    rate = LATVIA_RATE;
                }
                else if (countryCode == LITHUANIA_CODE)
                {
                    const decimal LITHUANIA_RATE = 1.12m;
                    rate = LITHUANIA_RATE;
                }
                else if (countryCode == MOLDOVA_CODE)
                {
                    const decimal MOLDOVA_RATE = 0.97m;
                    rate = MOLDOVA_RATE;
                }
                else if (countryCode == RUSSIA_CODE)
                {
                    const decimal RUSSIA_RATE = 1;
                    rate = RUSSIA_RATE;
                }
                else if (countryCode == TAJIKISTAN_CODE)
                {
                    const decimal TAJIKISTAN_RATE = 0.76m;
                    rate = TAJIKISTAN_RATE;
                }
                else if (countryCode == TURKMENISTAN_CODE)
                {
                    const decimal TURKMENISTAN_RATE = 0.81m;
                    rate = TURKMENISTAN_RATE;
                }
                else if (countryCode == UZBEKISTAN_CODE)
                {
                    const decimal UZBEKISTAN_RATE = 0.98m;
                    rate = UZBEKISTAN_RATE;
                }
                else if (countryCode == UKRAINE_CODE)
                {
                    const decimal UKRAINE_RATE = 1;
                    rate = UKRAINE_RATE;
                }
                else if (countryCode == ESTONIA_CODE)
                {
                    const decimal ESTONIA_RATE = 1.12m;
                    rate = ESTONIA_RATE;
                }
                else
                {
                    rate = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели несуществуещий код: {countryCode}!");
                }
            }

            decimal tilePriceWhithRate = tilePrice * rate;
            decimal tileCost = tileQuontiti * tilePriceWhithRate; // руб. 

            decimal discount; // руб.
            {
                decimal discountPersentage;
                {
                    bool discount20PctAvailable, discount50PctAvailable;
                    {
                        const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500, 
                                      MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000; // м. кв.
                        discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT 
                                              && tileQuontiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                        discount50PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                    }

                    if (discount20PctAvailable)
                    {
                        discountPersentage = 20; // %
                    }
                    else if (discount50PctAvailable)
                    {
                        discountPersentage = 50; //%
                    }
                    else
                    {
                        discountPersentage = 0; //%
                    }

                }

                discount = tileCost / 100 * discountPersentage;
            }

            decimal paymentAmoount = tileCost - discount;

            {
                Console.WriteLine($"Цена с коэффициентом  : {tilePriceWhithRate} руб.");
                Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
                Console.WriteLine($"Скидка                : {discount} руб.");
                Console.WriteLine($"Сумма к оплате        : {paymentAmoount} руб.");

            }


        }
    }
}
