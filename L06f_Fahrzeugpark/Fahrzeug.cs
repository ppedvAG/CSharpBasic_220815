﻿namespace L06f_Fahrzeugpark
{
    public abstract class Fahrzeug
    {
        #region Lab 06: Properties, Methoden, Konstruktor

        //Properties
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public bool MotorLäuft { get; set; }

        public int AnzahlRäder { get; set; }

        //Konstruktor mit Übergabeparametern und Standartwerten
        public Fahrzeug(string name, int maxG, double preis)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLäuft = false;
        }

        public Fahrzeug()
        {

        }

        //Methode zur Ausgabe von Objektinformationen | virtual erlaubt das Überschreiben durch erbende Klassen
        public virtual string Info()
        {
            if (this.MotorLäuft)
                return $"{this.Name} kostet {this.Preis}€ und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h.";
            else
                return $"{this.Name} kostet {this.Preis}€ und könnte maximal {this.MaxGeschwindigkeit}km/h fahren.";
        }

        //Methode zum Starten des Motors
        public void StarteMotor()
        {
            if (this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} läuft bereits.");
            else
            {
                this.MotorLäuft = true;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestartet.");
            }
        }

        //Methode zum Stoppen des Motors
        public void StoppeMotor()
        {
            if (!this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} ist bereits gestoppt");
            else if (this.AktGeschwindigkeit > 0)
                Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {this.Name} noch bewegt");
            else
            {
                this.MotorLäuft = false;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt.");
            }
        }

        //Methode zum Beschleunigen und Bremsen
        public void Beschleunige(int a)
        {
            if (this.MotorLäuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;

                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
            }
        }

        #endregion

        #region Lab 07: Statische Member, Destruktor
        //Destruktor
        ~Fahrzeug()
        {
            Console.WriteLine($"{this.Name} wurde zerstört.");
        }

        //Statische Member
        public static int AnzahlAllerFahrzeuge { get; private set; } = 0;

        public static string ZeigeAnzahlAllerFahrzeuge()
        {
            return $"Es haben bist jetzt {AnzahlAllerFahrzeuge} Lebewesen existiert.";
        }

        #endregion

        #region Lab 09: Polymorphismus

        //statisches Feld für Zufallsgenerator
        protected static Random generator = new Random();
        //Methode zur zufälligen Generierung eines Fahrzeugs
        public static Fahrzeug GeneriereFahrzeug(string nameSuffix = "")
        {
            switch (generator.Next(1, 4))
            {
                //Instanziierung der jeweiligen spezifischen Fahrzeuge
                case 1:
                    return new PKW("Mercedes" + nameSuffix, 210, 23000, 5);
                case 2:
                    return new Schiff("Titanic" + nameSuffix, 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
                default:
                    return new Flugzeug("Boing" + nameSuffix, 350, 90000000, 9800);
            }
        }

        //Definition einer abstrakten Methode
        public abstract void Hupen();

        //override ToString() überschreibt die Standart-ToString()-Methode
        public override string ToString()
        {
            return this.GetType().Name + ": " + this.Name;
        }

        #endregion
    }
}