namespace Problema_lab5;

using System;
using System.Collections.Generic;

// ===================================================
// CLASA Apartment
// ===================================================
// Reprezintă o entitate simplă, care conține date despre un apartament.
// Concept OOP: ENCAPSULARE – datele sunt accesate prin proprietăți,
// nu direct prin câmpuri publice. În acest fel putem controla cine le modifică.
public class Apartment
{
    // Proprietăți cu get și set — pot fi citite și modificate din exterior
    public int Id { get; set; }
    public string Address { get; set; }
    public int Capacity { get; set; }
    public decimal PricePerDay { get; set; }

    // Constructor pentru inițializare
    public Apartment(int id, string address, int capacity, decimal pricePerDay)
    {
        Id = id;
        Address = address;
        Capacity = capacity;
        PricePerDay = pricePerDay;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[{Id}] {Address} — capacitate: {Capacity}, preț/zi: {PricePerDay:0.00} €");
    }
}