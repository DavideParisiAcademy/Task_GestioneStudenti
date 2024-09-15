using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_GestioneStudenti.Classes
{
    internal class Studente : Persona
    {
        #region Attributi
        public double Voto { get; set; }
        private long matricola;
        Random rand = new Random();
        List<long> matricole = new List<long>();
        bool ciclo = true;

        #endregion

        public Studente() { }

        #region Costruttore

        //Costruttore con generazione randomica delle matricole
        public Studente(string? varNome, string? varCognome, double varVoto)
        {

            this.Voto = varVoto;
            base.Nome = varNome;
            base.Cognome = varCognome;

            //Generazione Matricola random non negativa

             matricola = rand.NextInt64(0,10000);
             matricola = (int)matricola;
             matricole.Add(matricola);
  
            //Controllo di univocità della matricola (da rivedere: potenziale processo ricorsivo di verifica)

            //for(int i = 0; i < matricole.Count; i++)
            //{
            //    if (matricole[i] == matricola)
            //    {
            //        matricola = rand.NextInt64();
            //    }
            //}
        }
        #endregion

        public override string ToString()
        {
            return $"[Studente]:\nNome: {Nome}, Cognome: {Cognome}, Voto: {Voto}, Matricola: {matricola}";
        }
        public long GetMatricola()
        {
            return matricola;
        }

    }
}

