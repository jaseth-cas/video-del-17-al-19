// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*reglas de blackjack:
 * 1. si el jugador se pasa de 21 pierde
 * 2. si el jugador tiene cartas menor que el dealer el jugador pierde
 * 3.si el jugador tiene numero de cartas menor que 21 y mayor que el dealer, el jugador gana
 */

//se instancian las variables
int totjug = 0, totdeal = 0;
int num = 0, fic;
string message = "", ctrl= "s";
string switchctrl = "menu";
string ctrlcart = "";
System.Random random = new System.Random();

try //el try catch funciona para cuando existe un error de variables    
{   
    while (ctrl == "s")//mientras que
    {
        Console.WriteLine("Bienvenido al casino");
        Console.WriteLine("cuantas fichas quieres?\n"
            + "Ingresa un numero entero\n"
            + "recuerda que necesitas una por juego");
        fic = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < fic; i++)
        {

            totjug = 0;
            totdeal = 0;
            switch (switchctrl)//entramos al switch
            {
                case "menu"://si es menu entonces:
                    Console.WriteLine("Escriba '21 para jugar al 21'");
                    switchctrl = Console.ReadLine();
                    i--;
                    break;

                case "21":
                    do
                    {
                        num = random.Next(1, 12);
                        totjug = totjug + num;
                        Console.WriteLine("toma tu carta");
                        Console.WriteLine("te salio el numero:  " + num);
                        Console.WriteLine("llevas: " + totjug);
                        Console.WriteLine("¿deseas otra carta?");
                        ctrlcart = Console.ReadLine();
                    } while (ctrlcart == "si" || ctrlcart == "Si");

                    totdeal = random.Next(10, 23);
                    Console.WriteLine("el dealer obtuvo:" + totdeal);

                    //si el jugador gana al dealer
                    if (totjug > totdeal && totjug < 22)
                    {
                        message = "venciste al dealer";
                        switchctrl = "menu";
                    }
                    else if (totjug <= totdeal)//si el jugador tiene igual o menor de 21 pierde
                    {
                        message = "el dealer gano";
                        switchctrl = "menu";
                    }
                    else if (totjug > 21)// si el jugador se pasa de 21 pierde
                    {
                        message = "te pasaste de 21, perdiste";
                        switchctrl = "menu";
                    }
                    else // validando 
                    {
                        message = "condicion no valida";
                        switchctrl = "menu";
                    }

                    Console.WriteLine(message);
                    break;

                default://si hay algun error invalidado
                    Console.WriteLine("valor ingresado no valido para el casino");
                    break;
            }
        }
        Console.WriteLine("deseas continuar? (s) para si, (n) para no");
        ctrl = Console.ReadLine();
    }

    }catch (Exception)// manda el error 
{
    Console.WriteLine("Error de validacion, saldra del programa");
}


