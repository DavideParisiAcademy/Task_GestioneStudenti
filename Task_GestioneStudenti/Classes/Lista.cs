using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_GestioneStudenti.Classes
{
    internal class Lista
    {
        List<Studente> lista = new List<Studente>();
        Studente stu = new Studente();

        #region Metodi

        //1) POST
        public void AggiungiStudente(Studente stu)
        {
            lista.Add(stu);
            Console.WriteLine("Inserimento avvenuto con successo");
        }

        //2) GET
        public void StampaLista()
        {
            if (lista.Count > 0)
            {
                foreach (Studente st in lista)
                {
                    Console.WriteLine(st.ToString());
                }
            }
            else
            {
                Console.WriteLine("Lista vuota");
            }
        }

        //3) UPDATE
        public void ModificaStudente()
        {

            if (lista.Count == 0)
            {
                Console.WriteLine("ERRORE: nessuno studente presente nella lista");
            }
            else
            {
                Console.WriteLine("Inserisci la matricola dello studente");
                string? ricercaString = Console.ReadLine();
                int ricercaInt = Convert.ToInt32(ricercaString);
                foreach (Studente st in lista)
                {
                    if (ricercaInt == st.GetMatricola())
                    {
                        //modifica completa dello studente

                        Console.WriteLine("Modifica nome: ");
                        st.Nome = Console.ReadLine();
                        Console.WriteLine("Modifica Cognome: ");
                        st.Cognome = Console.ReadLine();
                        Console.WriteLine("Modifica voto: ");
                        string? votoString = Console.ReadLine();
                        st.Voto = Convert.ToInt32(votoString);
                    }

                    else
                    {
                        Console.WriteLine("Studente non trovato");

                    }
                }
            }
        }

        //4) DELETE
        public void EliminaStudente()
        {
            Console.WriteLine("Inserire il nome dello studente da eliminare"); 
            string? ricercaNome = Console.ReadLine();
            if (ricercaNome is null)
            {
                Console.WriteLine("ERRORE: il valore inserito non è valido");
            }
            else
            {
                for (int i = 0; i < lista.Count; i++ )
                {
                    if (lista[i].Nome == ricercaNome)
                    {
                        lista.Remove(lista[i]);
                        Console.WriteLine("Studente eliminato con successo");                
                    }
                    else
                    {
                        Console.WriteLine("Studente non trovato");
                    }
                }
            }         
        }  
        
        //5.1) VOTO MEDIO
        public void VotoMedio()
        {
            double somma = 0;
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    somma = somma + lista[i].Voto;
                }

                Console.WriteLine($"Voto medio: {somma / lista.Count()}");
            }
            else
            {
                Console.WriteLine("ERRORE: la lista è vuota");
            }        
        }

        //5.2) VOTO MASSIMO
        public void VotoMassimo()
        {
            double votoMax = lista[1].Voto;

            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    votoMax = Math.Max(lista[i].Voto, votoMax);
                }
                Console.WriteLine($"Voto massimo: {votoMax}");
            }
            else
            {
                Console.WriteLine("ERRORE: la lista è vuota");
            }
        }
        //5.3) VOTO MINIMO
        public void VotoMinimo()
        {
            double votoMin = lista[1].Voto;
            if(lista.Count > 0)
            {
            for(int i = 0; i< lista.Count; i++)
                {
                    votoMin = Math.Min(lista[i].Voto, votoMin);
                }
            Console.WriteLine($"Voto minimo: {votoMin}");
            }
            else
            {
                Console.WriteLine("ERRORE: la lista è vuota");
            }
        }   
        #endregion
    }
}
