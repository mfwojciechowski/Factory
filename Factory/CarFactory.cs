using System;
using System.Collections.Generic;
using Factory.Interface;

namespace Factory
{
    public class CarFactory
    {
        public static Dictionary<string, Func<ICar>> CarList = new Dictionary<string, Func<ICar>>()
        {
            { "Opel", () => new Opel()},
            { "Volks", () => new Volkswagen()},
            { "Porshe", () => new Porshe()}, 
            //lambda - odwolanie do funkcji; Func odwołuje się do funkcji
            // Teraz nie tworzy wszystkich instancji lecz te, ktore sa wywolywane
        };

        public static ICar CreateInstance(string text)
        {
            //var list = CarList.Values;
            return CarList.ContainsKey(text) ? CarList[text]() : null; //używa słownika i tworzy instancje po kluczu 
            // sprawdza czy zawiera klucz (text) i porownuje go z kluczem z listy
        }
    }
}