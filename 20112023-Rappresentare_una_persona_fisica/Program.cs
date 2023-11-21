using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20112023_Rappresentare_una_persona_fisica
{
    class Persona
    {
        private int codice;
        private string cognome;
        private string nome;
        private bool registrato;
        // Costruttore
        public Persona(int codice, string cognome, string nome)
        {
            this.codice = codice;
            this.cognome = cognome;
            this.nome = nome;
            this.registrato = false; // Inizialmente la persona non è registrata
        }
        // Metodo per registrare la persona
        public void Registra()
        {
            // Simulazione di un processo di registrazione/approvazione
            Console.WriteLine($"La persona {nome} {cognome} con codice {codice} è stata registrata.");
            registrato = true;
        }
        // Metodo per mostrare i dati della persona
        public void Mostra()
        {
            Console.WriteLine($"Codice: {codice}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cognome: {cognome}");
            Console.WriteLine($"Registrato: {(registrato ? "Sì" : "No")}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Richiedi all'utente di inserire i dati anagrafici della persona
            Console.WriteLine("Inserisci il codice della persona:");
            int codicepersona;
            while (!int.TryParse(Console.ReadLine(), out codicepersona))
            {
                Console.WriteLine("Non puoi inserire un carattere diverso da un numero!\nInserisci un codice valido:");
            }
            while (codicepersona <= 0)
            {
                Console.WriteLine("inserire un codice maggiore di 0");
                codicepersona = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Inserisci il cognome della persona:");
            string cognomepersona = Console.ReadLine();
            Console.WriteLine("Inserisci il nome della persona:");
            string nomepersona = Console.ReadLine();
            Console.Clear();
            // Creazione dell'oggetto Persona con i dati inseriti dall'utente
            Persona persona = new Persona(codicepersona, cognomepersona, nomepersona);
            // Mostra i dati della persona prima della registrazione
            Console.WriteLine("Dati della persona prima della registrazione:");
            persona.Mostra();
            // Chiedi all'utente se desidera registrare la persona
            Console.WriteLine("Vuoi registrare questa persona? (Sì/No)");
            string risposta = Console.ReadLine();
            if (risposta.ToLower() == "sì" || risposta.ToLower() == "si")
            {
                persona.Registra();
            }
            Console.Clear();
            // Mostra i dati della persona dopo la registrazione
            Console.WriteLine("Dati della persona dopo la registrazione:");
            persona.Mostra();
            Console.ReadLine(); // Aspetta un input per chiudere il programma
        }
    }
}
