// See https://aka.ms/new-console-template for more information

using Cerinta_Lab;

Persoana persoana = new Persoana(" Ion Popescu", 2021);
Persoana persoana2 = new Persoana(" Ion Ionescu", 2010);

List<Persoana> participanti = new List<Persoana> { persoana, persoana2 };

Rezervare rezervare1 = new Rezervare("Maria Georgescu", new DateTime(2022, 5, 10), 7, participanti, "B123");
Rezervare rezervare2 = new Rezervare("Maria Georgescu 2", new DateTime(2023, 5, 10), 7, participanti, "A123");

Companie companie = new Companie();
companie.AdaugaRezervare(rezervare1);
companie.AdaugaRezervare(rezervare2);