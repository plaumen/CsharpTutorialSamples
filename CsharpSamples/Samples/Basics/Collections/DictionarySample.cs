using CsharpSamples.Common.Interfaces;
using System.Collections.Generic;

namespace CsharpSamples.Samples.Basics.Collections
{
    public class DictionarySample : ISample
    {
        public void Run()
        {
            var translations = new Dictionary<string, Translation>();
            translations.Add(TranslationsKeys.Done, new Translation("Zrobione", "Done"));
            translations.Add(TranslationsKeys.ItemNotFound, new Translation("Przedmiot nie został znaleziony", "Item was not found"));

            var itemNotFoundPolishMessage = translations[TranslationsKeys.ItemNotFound].Polish;
            System.Console.WriteLine(itemNotFoundPolishMessage);


            var notExistingKey = "$Ssdfklj";
            try
            {
                var notExistingTranslation = translations[notExistingKey];
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine($"Exception was thrown. {e.Message}");
            }


            if (!translations.ContainsKey(notExistingKey))
            {
                System.Console.WriteLine($"Key {notExistingKey} was not found in dictionary");
            }

            // OUTPUT
            // Przedmiot nie zostal znaleziony
            // Exception was thrown.The given key '$Ssdfklj' was not present in the dictionary.
            // Key $Ssdfklj was not found in dictionary

        }
    }

    internal class Translation
    {
        public Translation(string polish, string english)
        {
            Polish = polish;
            English = english;
        }
        public string Polish { get; }

        public string English { get; }
    }

    public static class TranslationsKeys
    {
        public static string Done => "DONE";
        public static string ItemNotFound => "ITEM_NOT_FOUND";
    }
}
