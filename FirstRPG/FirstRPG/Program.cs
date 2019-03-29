using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string traveler; //Then name that the player chooses for his character
            string friend; //the friends name in a constant string

            int Delay2 = 4000; //The delay that i have put in for the dialog lines
            int Delay1 = 6000; //The delay for the new parts of the game
            int Delay4 = 8000; //The delay for the bigger lines of text
            int Delay3 = 1000; //The delay for the echos

            Console.ForegroundColor = ConsoleColor.Yellow; //This changes the color of the text

            Console.WriteLine("Hello and welcome to an adventure game where you are a man who's father had passed away");
            Thread.Sleep(Delay2);

            Console.WriteLine("and you have to take over his work and almost life. There will be interractions with other");
            Thread.Sleep(Delay2);

            Console.WriteLine("characters in the game that will be highlighted green, you will have the power there to either");
            Thread.Sleep(Delay2);

            Console.WriteLine("write something or choose a statement.\n"); //Writing \n in the end of this gives it a blank new line
            Thread.Sleep(Delay2);

            Console.WriteLine("The inner monolog will be gray where you get information regarding what's going on and why.");
            Thread.Sleep(Delay2);

            Console.WriteLine("When your character talks it will be in a blue color.\n");
            Thread.Sleep(Delay2);

            Console.WriteLine("Have fun playing this game and good luck, you will need it!\n");
            Thread.Sleep(Delay2);

            Console.WriteLine("Press enter to start the game");
            Console.ReadLine();

            Console.Clear(); //this clears what's on the console to make it easier to follow the story later

            Console.ForegroundColor = ConsoleColor.Gray; //The color for the inner monologue

            Console.WriteLine("You are about to access a cave that you only heard of in legends");
            Console.WriteLine("Behind you, you hear a voice asking you something that you can't quite make out");
            Thread.Sleep(Delay2);

            Console.ForegroundColor = ConsoleColor.Green; //Every time that you have to interract the color changes to green
            Console.WriteLine("What's your name!?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            traveler = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White; //The color for the other characters or sounds in the game
            Console.WriteLine("Okey {0} remember that everything can happen down there so don't get full of yourself!\n", traveler);

            Thread.Sleep(Delay2);


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Yea yea i know, i'm not a child anymore!\n");

            Thread.Sleep(Delay2);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("People always acted like i was just a child since i took over my fathers place on these expeditions");
            Console.WriteLine("no matter what i did. I wonder if i will see any of my friends in the cave so i don't feel so lonley.\n");
            Thread.Sleep(Delay1);

            Console.Clear();
            Savepoint:
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n˜”*°•.˜”*°• Part 1 •°*”˜.•°*”˜");
            Console.WriteLine("checkpoint\n");
            Console.WriteLine("Press enter to continue your jurney");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Finally were off the boat, just a long car ride left and then we should be at the entrance.");

            Thread.Sleep(Delay2);

            Console.WriteLine("When he got down to the huge entrance he could see that there was three people waiting for him.");

            Thread.Sleep(Delay2);

            Console.WriteLine("hmmm, one of them looks awfully familiar somehow, but i can't remember the name or from where.");

            Thread.Sleep(Delay2);

            Console.WriteLine("The only thing I can think about right now is the entrance and how it looks\n");

            Thread.Sleep(Delay2);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Wow, this place is bigger than i could ever imagen.\n");

            Thread.Sleep(Delay2);

            Console.WriteLine("Hello!\n");

            Thread.Sleep(Delay3);

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello..\n");
                Thread.Sleep(Delay3);
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Thread.Sleep(Delay2);

            Console.WriteLine("I should have known that there would be an echo from the yelling but because of that\none of them approced me with a happy look on her face\n");

            Thread.Sleep(Delay2);

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Thread.Sleep(Delay2);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Hi {0}. How have you been?", traveler);

            Thread.Sleep(Delay2);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Everything with her is so familiar, her smile, the looks, Wait"); //This is the companion/friend that will engage in the problems during the game

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hang on, aren'y you______");
            friend = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Yea! How are you? been a long time since we've seen each other\n");

            Console.ForegroundColor = ConsoleColor.Gray;

            Thread.Sleep(Delay2);

            Console.WriteLine("for how long? when was the last time i actually met her?\nEverytime i'm trying to remember, she cuts me off with some witty comments or questions", friend);

            Thread.Sleep(Delay2);

            Console.WriteLine("I don't have time to figure this out now, I can hear someone yelling in the background.\n");

            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(Delay2);

            Console.WriteLine("EVERYONE! PACK YOUR BAGS, IT'S TIME TO GO!\n");

            Console.ForegroundColor = ConsoleColor.Gray;

            Thread.Sleep(Delay2);

            Console.WriteLine("I didn't see who it was that was yelling but I know that it's probably one of the leders of this expedition");

            Thread.Sleep(Delay2);

            Console.WriteLine("the only reason that i'm not the leader is cause the people that was working for my dad didn't trust me to do it.\n");

            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(Delay2);

            Console.WriteLine("Hey, you wanna follow me to get my stuff? maybe we can talk a bit more about what's happend and all?\n");

            Console.ForegroundColor = ConsoleColor.Gray;

            Thread.Sleep(Delay2);

            Console.WriteLine("Is she asking me to follow just to chat or is there something she wants to say to me?\n");

            Thread.Sleep(Delay2);

            Console.ForegroundColor = ConsoleColor.Green;

            Wrong:

            Console.WriteLine("I need to answer her, what should I do? \n1. Follow her\n2. Go and get my stuff");
            int decision1 = Convert.ToInt32(Console.ReadLine());

                int follow = 1;
                int goaway = 2;

                    if (decision1 == follow)
                    {
                //Backstory and then going to the normal route

                //The dad was doing some rituals behind closed doors wile friend and the player was doing something together while they were yunger
                //They didn't know what he did so they took a sneak peek and an accident occured
                //he remembers it now after they were talking and tries to understand why 


                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Yea I would love too.");

                Thread.Sleep(Delay2);

                        

                        goto storyline;
                    }

                    if (decision1 == goaway)
                    {
                //missing the backstory and going back to the normal rout
                //the character wont know anything unless he talks to her later

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("I need to go and get my stuff, I can meet you later though.\n");

                Thread.Sleep(Delay2);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Okey just tell me if theres anything you need~\n");

                Thread.Sleep(Delay2);

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("I didn't have time to say anything more before she started to almost run to her stuff.\nTheres still something that's missing but I can't seem to remember what.");

                Thread.Sleep(Delay2);

                goto storyline;
                    }

                    else
                    {

                Console.WriteLine("You need to choose between 1 or 2, try again");
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();

                goto Wrong;
                    }

                    storyline:

                    //you get to know about the person that leads the expedition instead of you and why you're there
                    //you will start going in to the cavern and when they stop for a break you have the choise to talk to the third person that stood and waited for you
                    //If you choose not to you wont know anything about him except for the name

            Console.ReadLine();



            //int die = 1;
            //int save = 2;
            //int solution;

            //Console.WriteLine("want to die?\n 1 for yes 2 for no");
            //solution = Convert.ToInt32(Console.ReadLine());

            //if (solution == die)
            //{
            //    Console.WriteLine("you died\n press enter to restart from checkpoint");
            //    Console.ReadLine();
            //    Console.Clear();
            //    goto Savepoint;
            //}

            //else 
            //    Console.WriteLine("Yay you wanted to live");
            //    Console.ReadLine();

        }
    }
}
