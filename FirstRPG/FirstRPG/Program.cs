using System;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;

namespace FirstRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "The mysterious cave"; //This changes the 

            string traveler; //Then name that the player chooses for his character
            string friend; //the friends name in a constant string

            int Delay2 = 4000; //The delay that i have put in for the dialog lines
            int Delay1 = 6000; //The delay for the new parts of the game
            int Delay3 = 1000; //The delay for the echos
            int Delay4 = 8000; //The delay for the bigger lines of text
            ForegroundColor = Yellow; //This changes the color of the text

            WriteLine("Hello and welcome to an adventure game where you are a man who's father had passed away");
            //Thread.Sleep(Delay2);  Made a different approach so keeping this for context

            WriteLine("and you have to take over his work and almost life. There will be interractions with other");
            //Thread.Sleep(Delay2);

            WriteLine("characters in the game that will be highlighted green, you will have the power there to either");
            //Thread.Sleep(Delay2);

            WriteLine("write something or choose a statement.\n"); //Writing \n in the end of this gives it a blank new line
            //Thread.Sleep(Delay2);

            WriteLine("The inner monolog will be gray where you get information regarding what's going on and why.");
            //Thread.Sleep(Delay2);

            WriteLine("When your character talks it will be in a blue color.\n");
            //Thread.Sleep(Delay2);

            WriteLine("Have fun playing this game and good luck, you will need it!\n");
            //Thread.Sleep(Delay2);

            WriteLine("Press enter to start the game");
            ReadLine();

            Clear(); //this clears what's on the console to make it easier to follow the story later

            ForegroundColor = Gray; //The color for the inner monologue

            WriteLine("You are about to access a cave that you only heard of in legends");
            WriteLine("Behind you, you hear a voice asking you something that you can't quite make out");
            //Thread.Sleep(Delay2);

            ForegroundColor = Green; //Every time that you have to interract the color changes to green
            WriteLine("What's your name!?");
            ForegroundColor = Cyan;
            traveler = ReadLine();

            ForegroundColor = White; //The color for the other characters or sounds in the game
            WriteLine("Okey {0} remember that everything can happen down there so don't get full of yourself!\n", traveler);

            //Thread.Sleep(Delay2);

            ForegroundColor = Cyan;
            WriteLine("Yea yea i know, i'm not a child anymore!\n");

            //Thread.Sleep(Delay2);

            ForegroundColor = Gray;
            WriteLine("People always acted like i was just a child since i took over my fathers place on these expeditions");
            WriteLine("no matter what i did. I wonder if i will see any of my friends in the cave so i don't feel so lonley.\n");
            //Thread.Sleep(Delay1);
            ForegroundColor = Yellow;
            WriteLine("Press enter to continue");
            ReadKey();
            Clear();
            //Savepoint:

            ForegroundColor = Yellow;
            WriteLine("\n˜”*°•.˜”*°• Part 1 •°*”˜.•°*”˜");
            WriteLine("The Friend\n");
            /*WriteLine("Press enter to continue your jurney");
            ReadLine();
            Thread.Sleep(Delay2);*/

            ForegroundColor = Gray;

            WriteLine("Finally were off the boat, just a long car ride left and then we should be at the entrance.");

            //Thread.Sleep(Delay2);

            WriteLine("When he got down to the huge entrance he could see that there was three people waiting for him.");

            //Thread.Sleep(Delay2);

            WriteLine("hmmm, one of them looks awfully familiar somehow, but i can't remember the name or from where.");

            //Thread.Sleep(Delay2);

            WriteLine("The only thing I can think about right now is the entrance and how it looks\n");

            //Thread.Sleep(Delay2);

            ForegroundColor = Cyan;

            WriteLine("Wow, this place is bigger than i could ever imagen.\n");

            //Thread.Sleep(Delay2);

            WriteLine("Hello!\n");

            //Thread.Sleep(Delay3);

            ForegroundColor = White;

            for (int i = 0; i < 3; i++)
            {
                WriteLine("Hello..\n");
                //Thread.Sleep(Delay3);
            }

            ForegroundColor = Gray;

            //Thread.Sleep(Delay2);

            WriteLine("I should have known that there would be an echo from the yelling but because of that\none of them approced me with a happy look on her face\n");

            //Thread.Sleep(Delay2);

            WriteLine("Press enter to continue");
            ReadLine();

            Clear();

            //Thread.Sleep(Delay2);

            ForegroundColor = White;

            WriteLine("Hi {0}. How have you been?", traveler);

            //Thread.Sleep(Delay2);

            ForegroundColor = Gray;

            WriteLine("Everything with her is so familiar, her smile, the looks, Wait"); //This is the companion/friend that will engage in the problems during the game

            ForegroundColor = Green;

            WriteLine("Hang on, aren'y you______");
            friend = ReadLine();

            ForegroundColor = White;

            WriteLine("Yea! How are you? been a long time since we've seen each other\n");

            ForegroundColor = Gray;

            //Thread.Sleep(Delay2);

            WriteLine("for how long? when was the last time i actually met her?\nEverytime i'm trying to remember, she cuts me off with some witty comments or questions", friend);

            //Thread.Sleep(Delay2);

            WriteLine("I don't have time to figure this out now, I can hear someone yelling in the background.\n");

            ForegroundColor = White;

            //Thread.Sleep(Delay2);

            WriteLine("EVERYONE! PACK YOUR BAGS, IT'S TIME TO GO!\n");

            ForegroundColor = Gray;

            //Thread.Sleep(Delay2);

            WriteLine("I didn't see who it was that was yelling but I know that it's probably one of the leders of this expedition");

            //Thread.Sleep(Delay2);

            WriteLine("the only reason that i'm not the leader is cause the people that was working for my dad didn't trust me to do it.\n");

            ForegroundColor = White;

            //Thread.Sleep(Delay2);

            WriteLine("Hey, you wanna follow me to get my stuff? maybe we can talk a bit more about what's happend and all?\n");

            ForegroundColor = Gray;

            //Thread.Sleep(Delay2);

            WriteLine("Is she asking me to follow just to chat or is there something she wants to say to me?\n");

            //Thread.Sleep(Delay2);

            ForegroundColor = Green;

            Wrong:

            WriteLine("I need to answer her, what should I do? \n1. Follow her\n2. Go and get my stuff");
            int decision1 = Convert.ToInt32(ReadLine());

                int follow = 1;
                int goaway = 2;

                    if (decision1 == follow)
                    {
                /*Backstory and then going to the normal route

                The dad was doing some rituals behind closed doors wile friend and the player was doing something together while they were yunger
                They didn't know what he did so they took a sneak peek and an accident occured
                he remembers it now after they were talking and tries to understand why */


                ForegroundColor = Cyan;
                WriteLine("Yea I would love too.\n");

                //Thread.Sleep(Delay2);

                ForegroundColor = White;
                WriteLine("Good! My things is over there and it's just a couple of things to get me by\n");

                //Thread.Sleep(Delay2);

                ForegroundColor = Gray;
                WriteLine("When we were on our way she talked about how we used to play together at my father mansion cause it was so big.");
                //Thread.Sleep(Delay2);
                WriteLine("She also told me about the day that we stopped seeing each other, something about the room that my dad used to work in?");
                //Thread.Sleep(Delay2);
                WriteLine("When she told me all of this I started to remember about how we were chasing each other around and heard a strange sound from my dads office.");
                //Thread.Sleep(Delay2);
                WriteLine("I also remember that we wanted to take a sneak peek to see what he was working with but something went from good to really bad.");
                //Thread.Sleep(Delay2);
                WriteLine("Before I could cope all the things that she told me about and my memories she asked me something\n");
                //Thread.Sleep(Delay4);

                ForegroundColor = White;
                WriteLine("Hello??\n");
                //Thread.Sleep(Delay2);

                ForegroundColor = Cyan;
                WriteLine("What? Sorry, I drifted off\n");
                //Thread.Sleep(Delay2);

                ForegroundColor = White;
                WriteLine("Can you take that bag so we can go?\n");
                //Thread.Sleep(Delay2);

                ForegroundColor = Cyan;
                WriteLine("Yea yea no problem!\n");
                //Thread.Sleep(Delay2);

                ForegroundColor = Gray;
                WriteLine("There's so many things that I wanted to know but no time for it now. We need start the jurney into the cave.");
                //Thread.Sleep(Delay2);

                goto storyline;
                    }

                    if (decision1 == goaway)
                    {
                /*missing the backstory and going back to the normal rout
                the character wont know anything unless he talks to her later*/

                ForegroundColor = Gray;
                WriteLine("I need to go and get my stuff, I can meet you later though.\n");

                //Thread.Sleep(Delay2);

                ForegroundColor = White;
                WriteLine("Okey just tell me if theres anything you need.\n");

                //Thread.Sleep(Delay2);

                ForegroundColor = Gray;
                WriteLine("I didn't have time to say anything more before she started to almost run to her stuff.\nTheres still something that's missing but I can't seem to remember what.");

                //Thread.Sleep(Delay2);

                WriteLine("Eitherway I need to get going before someone starts to yell at me again.");

                //Thread.Sleep(Delay2);

                WriteLine("Hopefully theres gonna be more time for questions later.");

                //Thread.Sleep(Delay2);

                goto storyline;
                    }

                    else
                    {
                ForegroundColor = Yellow;
                WriteLine("You need to choose between 1 or 2, try again");
                WriteLine("Press enter to try again");
                ReadLine();
                Clear();

                goto Wrong;
                    }

            storyline:

                    /*you get to know about the person that leads the expedition instead of you and why you're there
                    you will start going in to the cavern and when they stop for a break you have the choise to talk to the third person that stood and waited for you
                    If you choose not to you wont know anything about him except for the name*/

            ForegroundColor = Gray;
            WriteLine("After I went to grab my stuff we started to gather at the meetup place where the already set up lights started to fade away.");
            //Thread.Sleep(Delay2);

            WriteLine("This cave must surely have been explored before so why is there only equipment for about 1 KM in?");
            //Thread.Sleep(Delay2);

            WriteLine("Hopefully we will get more information from Jack, I mean he didn't even know my name when we first got here..\n");
            //Thread.Sleep(Delay2);

            ForegroundColor = Yellow;
            WriteLine("Press enter to continue");
            ReadKey();

            Clear();

            ForegroundColor = Yellow;
            WriteLine("\n˜”*°•.˜”*°• Part 2 •°*”˜.•°*”˜");
            WriteLine("The long walk\n");

            ForegroundColor = White;
            WriteLine("Everybody! Come here and listen closely, this information could save your life.\n");
            //Thread.Sleep(Delay2);

            ForegroundColor = Gray;
            WriteLine("Finaly, maybe I can get some information from him, he refused to give me anything before we got here.\n");
            //Thread.Sleep(Delay2);

            ForegroundColor = White;
            WriteLine("Before we go down I'm gonna make some things clear. Never go ALONE! No one have gone down here and lived to tell the tale.\n");
            //Thread.Sleep(Delay2);

            WriteLine("Last time someone went down here there were 10 people that never came back. It's our jobb to find out what happend and why.\n");
            //Thread.Sleep(Delay2);

            WriteLine($"If anything happens you tell {traveler} and he will tell me okey?! I don't want anyone taking up my time so he will fix the problem");
            //Thread.Sleep(Delay2);

            ForegroundColor = Gray;
            WriteLine("Apparently he thinks that i'm his runner boy or something like that. I need to talk to him about all this, it's not okey!");
            WriteLine("I will have to do it later though, seems like everyone is eager to start walking already\n");

            //This is where i stopped using a sleep delay for the code to make it more readable and playable

            ForegroundColor = White;
            WriteLine($"{traveler} are you ready for this soo dangerous cave?\n");
            WriteLine("You heard the man, we could DIE!\n");

            ForegroundColor = Cyan;
            WriteLine("Ha ha ha so funny, hell yea i'm ready for this.\n");
            WriteLine("No one is as ready as I am right now.\n");

            ForegroundColor = White;
            WriteLine($"Hey! {traveler}, come here. I need to talk to you.\n");

            ForegroundColor = Gray;
            WriteLine("Why does he want to talk to me? Is this about the expedition?\n");

            ForegroundColor = Cyan;
            WriteLine($"On my way! {friend}, I will come back when we are done talking.\n");

            ForegroundColor = Gray;
            WriteLine("What does that old man want now, he went from not knowing my name to wanting to talk privately with me.");
            WriteLine("Either way I need to figureout why people haven't come back from the cave. Not for him but for Me.\n");

            ForegroundColor = Cyan;
            WriteLine("Okey, what did you wanna talk about?\n");

            ForegroundColor = White;
            WriteLine("Whatever you see down there, you must remember that people get lost down there and never come back. Don't Go Alone.\n");
            WriteLine("And if you see something down there tell me personaly ASAP.\n");

            ForegroundColor = Cyan;
            WriteLine("Yea sure no problem\n");

            ForegroundColor = Yellow;
            WriteLine("Press enter to continue");
            ReadKey();



            ReadKey();

            /* At some parts of the story where you can make a desicion you will have the option of going back and change the decision you have made to get more information or not. This doesn't apply to every instance in the game

            int die = 1;
            int save = 2;
            int solution;

            Console.WriteLine("want to die?\n 1 for yes 2 for no");
            solution = Convert.ToInt32(Console.ReadLine());

            if (solution == die)
            {
                Console.WriteLine("you died\n press enter to restart from checkpoint");
                Console.ReadLine();
                Console.Clear();
                goto Savepoint;
            }

            else 
                Console.WriteLine("Yay you wanted to live");
                Console.ReadLine();



            The creator of the storyline: Niazoon
            The creator of the game: Wazzzapp (John Blom)*/

        }
    }
}
