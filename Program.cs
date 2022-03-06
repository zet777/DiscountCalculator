

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string countryCode;
                decimal tileQuontiti, tilePrice;
                
                // countryCode, tileQuontiti, tilePrice = RunInputUserInterface ()
                {
                    const string COUNTRY_CODES =
                        "******************************************************************\n" +
                        "Азербаджан    (994)  |  Киргизия    (996)  |  Таджикистан    (992)\n" +
                        "Армения       (374)  |  Латвия      (371)  |  Туркмения      (993)\n" +
                        "Беларусь      (375)  |  Литва       (370)  |  Узбекистан     (998)\n" +
                        "Грузия        (995)  |  Молдова     (373)  |  Украина        (380)\n" +
                        "Казахстан     (007K)  |  Россия      (007)  |  Эстония        (372)\n" +
                        "------------------------------------------------------------------";
                    
                        Console.WriteLine(COUNTRY_CODES);

                    //countryCode = ProcessCountryCode (countryCode)
                    {

                        Console.WriteLine("Телефонный код страны: ");
                        countryCode = Console.ReadLine();

                        // countryCode = DetectKazakhstanCode (countryCode)
                        {

                            const string KAZAKHSTAN_CODE = "007";
                            const string LOWERCASE_ENGLISH_LETTER_k = "k", UPPERCASE_RUSSIAN_LETTER_K = "К",
                                LOWERCASE_RUSSIAN_LETTER_k = "к";

                            bool countryCodeIsKazakhstanCodeAndAnyLatterK =
                                countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_k) ||
                                countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_K) ||
                                countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_k);
                            if (countryCodeIsKazakhstanCodeAndAnyLatterK)
                            {
                                const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                            }
                        }

                        bool countryCodeIsCorrect;

                        //ChekCountryCode (countryCode)
                        { 
                            
                        }

                    }
                    
                    Console.Write("Количество плитки     : ");
                    string stringQuontiti = Console.ReadLine();
                    tileQuontiti = Convert.ToDecimal(stringQuontiti);

                    Console.Write("Цена за 1м. кв. плитки: ");
                    string stringPrice = Console.ReadLine();
                    tilePrice = Convert.ToDecimal(stringPrice);
                }

                decimal rate;

                // rate = CalculatePriceRate (countryCode)
                {
                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                    const string AZERBAIJANE_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                 GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTANN_CODE = "996",
                                 LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                 RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                 UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                    switch (countryCode)
                    {
                        case AZERBAIJANE_CODE:
                            {
                                const decimal AZERBAIJANE_RATE = 1.07m;
                                rate = AZERBAIJANE_RATE;
                                break;
                            }

                        case ARMENIA_CODE:
                            {
                                const decimal ARMENIA_RATE = 0.95m;
                                rate = ARMENIA_RATE;
                                break;
                            }

                        case GEORGIA_CODE:
                            {
                                const decimal GEORGIA_RATE = 0.94m;
                                rate = GEORGIA_RATE;
                                break;
                            }
                        case KAZAKHSTAN_CODE:
                            {
                                const decimal KAZAKHSTAN_RATE = 0.79m;
                                rate = KAZAKHSTAN_RATE;
                                break;
                            }
                        case KYRGYZSTANN_CODE:
                            {
                                const decimal KYRGYZSTANN_RATE = 0.83m;
                                rate = KYRGYZSTANN_RATE;
                                break;
                            }

                        case MOLDOVA_CODE:
                            {
                                const decimal MOLDOVA_RATE = 0.97m;
                                rate = MOLDOVA_RATE;
                                break;
                            }

                        case TAJIKISTAN_CODE:
                            {
                                const decimal TAJIKISTAN_RATE = 0.76m;
                                rate = TAJIKISTAN_RATE;
                                break;
                            }
                        case TURKMENISTAN_CODE:
                            {
                                const decimal TURKMENISTAN_RATE = 0.81m;
                                rate = TURKMENISTAN_RATE;
                                break;
                            }
                        case UZBEKISTAN_CODE:
                            {
                                const decimal UZBEKISTAN_RATE = 0.98m;
                                rate = UZBEKISTAN_RATE;
                                break;
                            }
                        case BELARUS_CODE:
                        case UKRAINE_CODE:
                        case RUSSIA_CODE:
                            {
                                const decimal RUSSIA_RATE = 1;
                                rate = RUSSIA_RATE;
                                break;
                            }
                        case LATVIA_CODE:
                        case LITHUANIA_CODE:
                        case ESTONIA_CODE:
                            {
                                const decimal PRIBALTIKA_RATE = 1.12m;
                                rate = PRIBALTIKA_RATE;
                                break;
                            }
                        default:
                            {
                                rate = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Вы ввели несуществуещий код: {countryCode}!");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
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

                //RunInputUserInterface (tilePriceWithRate, tileCost, discount, paymentAmount)
                {
                    Console.WriteLine($"Цена с коэффициентом  : {tilePriceWhithRate} руб.");
                    Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
                    Console.WriteLine($"Скидка                : {discount} руб.");
                    Console.WriteLine($"Сумма к оплате        : {paymentAmoount} руб.");

                }

                Console.WriteLine("******************************************************************\n"+
                                        "Нажмите Enter, для начала обслуживания нового клиента");
            }

        }
    }
}