using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    private int lives;
    private float speed = 3.2f;
    private string greeting = "Hello Artemis.";

    private string[] easy = {"book", "shelf", "librarian", "borrow", "password" };
    private string[] medium = { "arrest", "dangerous", "detective", "handcuff", "innocent" };
    private string[] hard = { "aphelion", "bolometer", "conjunction", "eccentricity", "gegenschein" };

    private string[] easyClue = {"kboo", "fslhe", "nlaiibrra", "wboorr", "dpraosws" };
    private string[] mediumClue = { "tasrer", "sduaonrge", "edveittec", "fhfauncd", "tinnenco" };
    private string[] hardClue = { "naopihle", "rbeotleom", "ncoointjcun", "yetcicceinrt", "ngieeghecns" };

    private int counter1, counter2, counter3;
    private int type;

    private string clue = "One from start one from end, how is \n" +
        "it going to end?";
    // Start is called before the first frame update
    void Start()
    {
        showMainMenu(greeting);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnUserInput(string input)
    {
        switch(input)
        {
            case "1":
                Terminal.ClearScreen();
                Terminal.WriteLine(clue);
                lives = 3;
                counter1 = 0;
                type = 1;
                break;
            case "2":
                Terminal.ClearScreen();
                Terminal.WriteLine(clue);
                lives = 3;
                counter2 = 0;
                type = 2;
                break;
            case "3":
                Terminal.ClearScreen();
                Terminal.WriteLine(clue);
                lives = 3;
                counter3 = 0;
                type = 3;
                break;
        }

        if(lives > 1)
        {
            if (type == 1)
            {
                getLives();
                checkTypePrintClue(counter1, type, input, lives);
            }
            else if (type == 2)
            {
                getLives();
                checkTypePrintClue(counter2, type, input, lives);
            }
            else
            {
                getLives();
                checkTypePrintClue(counter3, type, input, lives);
            }
        } else if(lives == 1)
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("You should try again young padawan");
            Terminal.WriteLine("Press 1 to play this level again, 2 to\n" +
            "play medium level or 3 to hard level.");
        }
    }

    void setLives(int live)
    {
        this.lives = live;
    }

    int getLives()
    {
        return this.lives;
    }

    void checkTypePrintClue(int counter, int level, string input, int live)
    {
        if (level == 1)
            {
                switch (counter)
                {
                    case 0:
                        if (input == "1")
                        {
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Clue is : " + easyClue[0]);
                        }
                        else if (input.Equals(easy[0]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + easyClue[1]);
                            counter1++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + easyClue[0]);
                        }
                        break;
                    case 1:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + easyClue[1]);

                        if (input.Equals(easy[1]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + easyClue[2]);
                            counter1++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + easyClue[1]);
                        }
                        break;
                    case 2:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + easyClue[2]);

                        if (input.Equals(easy[2]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + easyClue[3]);
                            counter1++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + easyClue[2]);
                        }
                        break;
                    case 3:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + easyClue[3]);

                        if (input.Equals(easy[3]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + easyClue[4]);
                            counter1++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + easyClue[3]);
                        }
                        break;
                    case 4:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + easyClue[4]);

                        if (input.Equals(easy[4]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("You finished the easy level, press 1\n" +
                            "to play this level again, 2 to\n" +
                            "play medium level or 3 to hard level.");
                            counter1 = 0;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + easyClue[4]);
                        }
                        break;
                }
            }
        else if (level == 2)
            {
                switch (counter)
                {
                    case 0:
                        if (input == "2")
                        {
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Clue is : " + mediumClue[0]);
                        }
                        else if (input.Equals(medium[0]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + mediumClue[1]);
                            counter2++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + mediumClue[0]);
                        }
                        break;
                    case 1:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + mediumClue[1]);

                        if (input.Equals(medium[1]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + mediumClue[2]);
                            counter2++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + mediumClue[1]);
                        }
                        break;
                    case 2:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + mediumClue[2]);

                        if (input.Equals(medium[2]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + mediumClue[3]);
                            counter2++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + mediumClue[2]);
                        }
                        break;
                    case 3:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + mediumClue[3]);

                        if (input.Equals(medium[3]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + mediumClue[4]);
                            counter2++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + mediumClue[3]);
                        }
                        break;
                    case 4:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + mediumClue[4]);

                        if (input.Equals(medium[4]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("You finished the easy level, press 1\n" +
                            "to play this level again, 2 to\n" +
                            "play medium level or 3 to hard level.");
                            counter2 = 0;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + mediumClue[4]);
                        }
                        break;
                }
            }
        else if (level == 3)
            {
                switch (counter3)
                {
                    case 0:
                        if (input == "3")
                        {
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Clue is : " + hardClue[0]);
                        }
                        else if (input.Equals(hard[0]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + hardClue[1]);
                            counter3++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + hardClue[0]);
                        }
                        break;
                    case 1:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + hardClue[1]);

                        if (input.Equals(hard[1]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + hardClue[2]);
                            counter3++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + hardClue[1]);
                        }
                        break;
                    case 2:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + hardClue[2]);

                        if (input.Equals(hard[2]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + hardClue[3]);
                            counter3++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + hardClue[2]);
                        }
                        break;
                    case 3:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + hardClue[3]);

                        if (input.Equals(hard[3]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("Clue is : " + hardClue[4]);
                            counter3++;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + hardClue[3]);
                        }
                        break;
                    case 4:
                        Terminal.WriteLine("Remaining Lives : " + live);
                        Terminal.WriteLine("Clue is : " + hardClue[4]);

                        if (input.Equals(hard[4]))
                        {
                            Terminal.ClearScreen();
                            Terminal.WriteLine("Well done!");
                            Terminal.WriteLine("You finished the easy level, press 1\n" +
                            "to play this level again, 2 to\n" +
                            "play medium level or 3 to hard level.");
                            counter3 = 0;
                        }
                        else
                        {
                            Terminal.ClearScreen();
                            live--;
                            setLives(live);
                            Terminal.WriteLine("Remaining Lives : " + live);
                            Terminal.WriteLine("Try Again!");
                            Terminal.WriteLine(clue);
                            Terminal.WriteLine("Clue is : " + hardClue[4]);
                        }
                        break;
                }
            }
    }

    void showMainMenu(string greetingText)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greetingText);
        Terminal.WriteLine("The choice you are going to make will\n" +
            "change your life, choose wisely...");
        Terminal.WriteLine("Are you going to hack into : \n" +
            "1 - Public library?\n" +
            "2 - Police station?\n" +
            "3 - NASA?\n" +
            "(Press 1, 2 or 3)\n" +
            "Enter your selection : ");
    }
}
