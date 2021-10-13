using System;
using System.Collections.Generic;


namespace GCDevBuildGetToKnowClassmatesLab
{
    class Program
    {
        static void Main(string[] args)
            //The main difference between lists and array are an array is a set size while lists may shrink or grow. 
        {
            bool goOn = true;

            Console.WriteLine("Welcome to our C# class :)");
            Console.WriteLine();

            List<string> classMates = new List<string>();
            classMates.Add("1.  Calyn Greene");
            classMates.Add("2.  Andy Beer");
            classMates.Add("3.  Anurag Reddy");
            classMates.Add("4.  Cordero Ebberhart");
            classMates.Add("5.  Cortez Christian");
            classMates.Add("6.  Cullin Flynn");
            classMates.Add("7.  Erin Walter");
            classMates.Add("8.  Ese Jackson");
            classMates.Add("9.  Huy Phan");
            classMates.Add("10. James Mitchell");
            classMates.Add("11. Madalina Varasteanu");
            classMates.Add("12. Marjorie Patton");
            classMates.Add("13. Phillip Conrad");
            classMates.Add("14. Ramone Lynch");
            classMates.Add("15. Richard Moss");
            classMates.Add("16. Rick Magdeleno");
            classMates.Add("17. Ryan Raczak");
            classMates.Add("18. Yosha Kunnummal");
            classMates.Add("19. Zachary Parr");
            classMates.Add("20. Tommy Waalkes");

            foreach (string a in classMates)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            string result1 = GetInput("Which student would you like to learn more about ? (enter a number 1 - 20)");
            Console.WriteLine();

            int classMateNum;
            bool validNum;
            validNum = int.TryParse(result1, out classMateNum);
            
                
                if (classMateNum < 1 || classMateNum > 20 )
                {
                    Console.WriteLine("That student does not exist. Please try again. (Enter a number between 1 and 20): ");
                    validNum = Continue2();


                }
               

            
            String[] ClassMates = {"Calyn Greene", "Andy Beer", "Anurag Reddy", "Cordero Ebberhart",  "Cortez Christian", "Cullin Flynn", "Erin Walter", "Ese Jackson", "Huy Phan", "James Mitchell", "Madalina Varasteanu",  "Marjorie Patton",
                 "Phillip Conrad", "Ramone Lynch", "Richard Moss","Rick Magdeleno" ,"Ryan Raczak" , "Yosha Kunnummal", "Zachary Parr", "Tommy Waalkes"};

            String[] HomeTowns = { "Portage, MI", "Berkley, MI", "Rochester Hills, MI", "Berkley, MI", "Detroit, MI", "Fowlerville, MI", "Troy, MI", "Detroit, MI", "Lansing, MI", "Yap, FSM", "Saint Clair Shores, MI", "Detroit, MI", "Canton, MI", "Fort Lauderdale, FL", "Canton, MI", "Gilbert, AZ", "Detroit", "Detroit, MI", "Wyandotte, MI", "Raleigh, NC" };
            String[] FavFoods = { "Mac and Cheese", "French Fries", "Tacos", "BBQ", "Chicken Fettuccine Alfredo", "Pad Thai", "Tacos", "Shrimp", "Korean BBQ", "Katsu", "Fries", "Lasagna", "Fried Chicken", "Chicken Soup", "Sushi", "Hamburger", "Pizza", "Pizza", "Sushi", "Curry" };
            int[] ClassMateNumbers = new int[20];
            ClassMateNumbers[0] = 1;
            ClassMateNumbers[1] = 2;
            ClassMateNumbers[2] = 3;
            ClassMateNumbers[3] = 4;
            ClassMateNumbers[4] = 5;
            ClassMateNumbers[5] = 6;
            ClassMateNumbers[6] = 7;
            ClassMateNumbers[7] = 8;
            ClassMateNumbers[8] = 9;
            ClassMateNumbers[9] = 10;
            ClassMateNumbers[10] = 11;
            ClassMateNumbers[11] = 12;
            ClassMateNumbers[12] = 13;
            ClassMateNumbers[13] = 14;
            ClassMateNumbers[14] = 15;
            ClassMateNumbers[15] = 16;
            ClassMateNumbers[16] = 17;
            ClassMateNumbers[17] = 18;
            ClassMateNumbers[18] = 19;
            ClassMateNumbers[19] = 20;
            while (goOn)
            {
                if (classMateNum == 1)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[0]} is { ClassMates[0] }.What would you like to know about {ClassMates[0]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[0]} is from {HomeTowns[0]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[0]} really likes {FavFoods[0]}");
                        goOn = Continue();
                       
                    }


                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");
                        goOn = Continue();
                        
              
                    }


                }

                else if (classMateNum == 2)
                {

                    string result2 = GetInput($"Student { ClassMateNumbers[1]} is { ClassMates[1] }.What would you like to know about {ClassMates[1]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();

                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[1]} is from {HomeTowns[1]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[1]} really likes {FavFoods[1]}");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 3)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[2]} is { ClassMates[2] }.What would you like to know about {ClassMates[2]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[2]} is from {HomeTowns[2]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[2]} really likes {FavFoods[2]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 4)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[3]} is { ClassMates[3] }.What would you like to know about {ClassMates[3]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[3]} is from {HomeTowns[3]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[3]} really likes {FavFoods[3]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 5)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[4]} is { ClassMates[4] }.What would you like to know about {ClassMates[4]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[4]} is from {HomeTowns[4]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[4]} really likes {FavFoods[4]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    };
                }
                else if (classMateNum == 6)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[5]} is { ClassMates[5] }.What would you like to know about {ClassMates[5]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[5]} is from {HomeTowns[5]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[5]} really likes {FavFoods[5]}");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 7)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[6]} is { ClassMates[6] }.What would you like to know about {ClassMates[6]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[6]} is from {HomeTowns[6]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[6]} really likes {FavFoods[6]}");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 8)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[7]} is { ClassMates[7] }.What would you like to know about {ClassMates[7]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[7]} is from {HomeTowns[7]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[7]} really likes {FavFoods[7]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 9)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[8]} is { ClassMates[8] }.What would you like to know about {ClassMates[8]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[8]} is from {HomeTowns[8]}");
                        goOn = Continue();

                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[8]} really likes {FavFoods[8]}");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");
                    }
                }
                else if (classMateNum == 10)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[9]} is { ClassMates[9] }.What would you like to know about {ClassMates[9]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[9]} is from {HomeTowns[9]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[9]} really likes {FavFoods[9]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 11)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[10]} is { ClassMates[10] }.What would you like to know about {ClassMates[10]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[10]} is from {HomeTowns[10]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[10]} really likes {FavFoods[10]}");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 12)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[11]} is { ClassMates[11] }.What would you like to know about {ClassMates[11]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[11]} is from {HomeTowns[11]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[11]} really likes {FavFoods[11]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 13)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[12]} is { ClassMates[12] }.What would you like to know about {ClassMates[12]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[12]} is from {HomeTowns[12]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[12]} really likes {FavFoods[12]}");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 14)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[13]} is { ClassMates[13] }.What would you like to know about {ClassMates[13]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[13]} is from {HomeTowns[13]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[13]} really likes {FavFoods[13]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 15)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[14]} is { ClassMates[14] }.What would you like to know about {ClassMates[14]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[14]} is from {HomeTowns[14]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[14]} really likes {FavFoods[14]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");


                    }
                }
                else if (classMateNum == 16)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[15]} is { ClassMates[15] }.What would you like to know about {ClassMates[15]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[15]} is from {HomeTowns[15]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[15]} really likes {FavFoods[15]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 17)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[16]} is { ClassMates[16] }.What would you like to know about {ClassMates[16]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[16]} is from {HomeTowns[16]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[16]} really likes {FavFoods[16]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 18)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[17]} is { ClassMates[17] }.What would you like to know about {ClassMates[17]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[17]} is from {HomeTowns[17]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[17]} really likes {FavFoods[17]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 19)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[18]} is { ClassMates[18] }.What would you like to know about {ClassMates[18]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[18]} is from {HomeTowns[18]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[18]} really likes {FavFoods[18]}");
                        goOn = Continue();

                    }
                    else
                    {
                        Console.WriteLine("That data does not exist");
                        Console.WriteLine("Please Try Again");

                    }
                }
                else if (classMateNum == 20)
                {
                    string result2 = GetInput($"Student { ClassMateNumbers[19]} is { ClassMates[19] }.What would you like to know about {ClassMates[19]}? (enter \"Hometown\" or \"Favorite Food\"): ").ToLower();



                    if (result2 == "hometown")
                    {
                        Console.WriteLine($"{ClassMates[19]} is from {HomeTowns[19]}");
                        goOn = Continue();
                    }
                    else if (result2 == "favorite food")
                    {
                        Console.WriteLine($"{ClassMates[19]} really likes {FavFoods[19]}");
                        goOn = Continue();

                    }
                    
                }
                else
                {
                    Console.WriteLine("That data does not exist");
                    Console.WriteLine("Please Try Again");

                }
               // goOn = Continue();
            }
        }


   
        
            public static string GetInput(string promptToUser)
        {
            Console.Write(promptToUser);
            string userOutput = Console.ReadLine().ToLower();

            return userOutput;
        }


        public static bool Continue()
        {
            string answer = GetInput("Would you like to know more? Y/N ");

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Thank you!");
                return false;


            }
            else
            {
                Console.WriteLine("I'm sorry I didnt understand that");
                Console.WriteLine("Let's try again.");
                return Continue(); 
            }

        }
        public static bool Continue2()
        {
            string answer = GetInput("Please Try Again.");

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Thank you!");
                return false;


            }
            else
            {
                Console.WriteLine("I'm sorry I didnt understand that");
                Console.WriteLine("Let's try again.");
                return Continue();
            }

        }



    }
}


