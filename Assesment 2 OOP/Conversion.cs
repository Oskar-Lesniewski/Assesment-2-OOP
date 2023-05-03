namespace Assesment2
{
    // Class That Converts Cards To Numbers And Operators.
    class Conversion
    {
        // Converting Method For 3 Cards.
        public static void Conversion3(string Operator, float Number1, float Number2, int Difficulty, int Correct, int Wrong, int Test)
        {

            if (Operator == "Diamonds")
            {
                Operator = "+";
                float Answer = Number1 + Number2;
                Round.Round3(Answer, Number1, Number2, Operator, Difficulty, Correct, Wrong, Test);
            }
            else if (Operator == "Clubs")
            {
                Operator = "-";
                float Answer = Number1 - Number2;
                Round.Round3(Answer, Number1, Number2, Operator, Difficulty, Correct, Wrong, Test);
            }
            else if (Operator == "Hearts")
            {
                Operator = "*";
                float Answer = Number1 * Number2;
                Round.Round3(Answer, Number1, Number2, Operator, Difficulty, Correct, Wrong, Test);
            }
            else if (Operator == "Spades")
            {
                Operator = "/";
                float Answer = Number1 / Number2;
                Round.Round3(Answer, Number1, Number2, Operator, Difficulty, Correct, Wrong, Test);
            }
        }
        // Converting Method For 5 Cards.
        public static void Conversion5(string Operator1, string Operator2, float Number1, float Number2, float Number3, int Difficulty, int Correct, int Wrong, int Test)
        {
            if (Operator1 == "Diamonds")
            {
                Operator1 = "+";
                if (Operator2 == "Diamonds")
                {
                    Operator2 = "+";
                    float Answer = Number1 + Number2 + Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Clubs")
                {
                    Operator2 = "-";
                    float Answer = Number1 + Number2 - Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Hearts")
                {
                    Operator2 = "*";
                    float Answer = Number1 + Number2 * Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Spades")
                {
                    Operator2 = "/";
                    float Answer = Number1 + Number2 / Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }


            }
            else if (Operator1 == "Clubs")
            {
                Operator1 = "-";
                if (Operator2 == "Diamonds")
                {
                    Operator2 = "+";
                    float Answer = Number1 - Number2 + Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Clubs")
                {
                    Operator2 = "-";
                    float Answer = Number1 - Number2 - Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Hearts")
                {
                    Operator2 = "*";
                    float Answer = Number1 - Number2 * Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Spades")
                {
                    Operator2 = "/";
                    float Answer = Number1 - Number2 / Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
            }


            else if (Operator1 == "Hearts")
            {
                Operator1 = "*";
                if (Operator2 == "Diamonds")
                {
                    Operator2 = "+";
                    float Answer = Number1 * Number2 + Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Clubs")
                {
                    Operator2 = "-";
                    float Answer = Number1 * Number2 - Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Hearts")
                {
                    Operator2 = "*";
                    float Answer = Number1 * Number2 * Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Spades")
                {
                    Operator2 = "/";
                    float Answer = Number1 * Number2 / Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
            }


            else if (Operator1 == "Spades")
            {
                Operator1 = "/";
                if (Operator2 == "Diamonds")
                {
                    Operator2 = "+";
                    float Answer = Number1 / Number2 + Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Clubs")
                {
                    Operator2 = "-";
                    float Answer = Number1 / Number2 - Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Hearts")
                {
                    Operator2 = "*";
                    float Answer = Number1 / Number2 * Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
                else if (Operator2 == "Spades")
                {
                    Operator2 = "/";
                    float Answer = Number1 / Number2 / Number3;
                    Round.Round5(Answer, Number1, Number2, Number3, Operator1, Operator2, Difficulty, Correct, Wrong, Test);
                }
            }
        }
    }
}