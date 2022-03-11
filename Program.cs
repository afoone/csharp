using System;

namespace hola_mundo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string response = "";
            Chest chest = Chest.Locked;

            while (response != "exit")
            {
                string state = "";

                switch (chest)
                {
                    case Chest.Locked:
                        state = "cerrado con llave";
                        break;
                    case Chest.Closed:
                        state = "cerrado";
                        break;
                    case Chest.Open:
                        state = "abierto";
                        break;
                }

                Console.Write($"Está {state}, ¿Qué haces?");
                response = Console.ReadLine();

                switch (response)
                {
                    case "unlock":
                        if (chest == Chest.Locked)
                            chest = Chest.Closed;
                        break;
                    case "open":
                        if (chest == Chest.Closed)
                            chest = Chest.Open;
                        break;
                    case "close":
                        if (chest == Chest.Open)
                            chest = Chest.Closed;
                        break;
                    case "lock":
                        if (chest == Chest.Closed)
                            chest = Chest.Locked;
                        break;
                }


            }

            Console.WriteLine("juego finalizado");
        

          

        }

        enum Chest { Open, Closed, Locked }; // los nuevo tipos tienen que ir detrás de código o en otro fichero

    }
}
