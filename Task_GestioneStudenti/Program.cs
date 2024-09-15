using Task_GestioneStudenti.Classes;

namespace Task_GestioneStudenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMMA PER LA GESTIONE DEGLI STUDENTE");
            Lista lista = new Lista();

            bool ciclo = true;

            while (ciclo)
            {
                string? nome;
                string? cognome;
                string? votoString;
                


                Console.WriteLine("Scegli tra le seguenti opzioni:\n1-Aggiungi Studente\n2-Modifica Studente\n3-Visualizza lista\n4-Rimuovi Studente\n5-Operazioni sui voti\nQ-Esci");
                string? inputUtente = Console.ReadLine();
                inputUtente = inputUtente.ToUpper();
                
                
                switch (inputUtente)
                {
                    case "1":
                        Console.WriteLine($"Inserisci nome:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserisci cognome:");
                        cognome = Console.ReadLine();
                        Console.WriteLine("Inserisci voto");
                        votoString = Console.ReadLine();
                        double votoDouble = Convert.ToDouble(votoString);

                        if (votoDouble > 0 && votoDouble <= 10)
                            {
                                Studente stu = new Studente(nome, cognome, votoDouble);
                                lista.AggiungiStudente(stu);
                            }
                        else
                            {
                                Console.WriteLine("ERRORE DI INSERIMENTO: il voto dev'essere compreso fra 0 e 10");
                            }
                         break;
                    case "2":
                        lista.ModificaStudente();
                        break;
                    case "3":
                        lista.StampaLista();
                        break;
                    case "4":
                        lista.EliminaStudente();
                        break;
                    case "5":
                        Console.WriteLine("Scegli tre le seguenti operazioni:\n1-Voto medio\n2-Voto massimo\n3-Voto minimo");
                        string? inputUtente1 = Console.ReadLine();
                        switch (inputUtente1)
                        {
                            case "1":
                                lista.VotoMedio();
                                break;
                            case "2":
                                lista.VotoMassimo();
                                break;
                            case "3":
                                lista.VotoMinimo();
                                break;
                            default:
                                Console.WriteLine("ERRORE DI INSERIMENTO");
                                break;
                        }
                        break;
                    case "Q":
                        ciclo = false;
                        break;
                    default:
                        Console.WriteLine("ERRORE DI INSERIMENTO");
                        break;
                }

            }
        }
    }
}
