class Calculator{

    public int Calc(string znak, int number1, int number2) {
        int result = 0;

        if(znak == "+")
        {


            result = number1 + number2;
        }
        else if(znak == "-")
        {
            result = number1 - number2;





        }
        
        else if(znak == "/")
        {
            result = number1 / number2;


        }
    
        else if(znak == "*")
        {
            result = number1 * number2;


        }
        else
        {

            Console.WriteLine("Неверная Операция");

        }

        return result;

    }


}