using System;
using System.Collections.Generic;
using System.IO;
using Business.Architecture.Services.Interfaces;
using UnityEngine;

namespace Business.Architecture.Services
{
    public class CalculatorCashService : ICalculatorCashService
    {
        private const string FilePath = "cashData.txt";
        private const string CurrentInputSaveId = "Current Input";
        
        private readonly List<string> _cash = new();

        public string CurrentInput { get; private set; }

        public void Cash(string data)
        {
            _cash.Add(data);
            SaveData();
        }

        public void CashCurrentInput(string input)
        {
            CurrentInput = input;
            PlayerPrefs.SetString(CurrentInputSaveId, input);
            PlayerPrefs.Save();
        }

        public string GetCash()
        {
            return string.Join(Environment.NewLine, _cash);
        }

        public void Load()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    _cash.AddRange(File.ReadAllLines(FilePath));
                }
                else
                {
                    Console.WriteLine("Файл не знайдено.");
                }
            }
            catch (Exception exception)
            {
                Debug.Log($"Error while loading calculator cash: {exception.Message}");
            }

            LoadCurrentInput();
        }

        public void Clear()
        {
            _cash.Clear();

            if (File.Exists(FilePath))
                File.Delete(FilePath);
        }
        
        private void SaveData()
        {
            try
            {
                File.WriteAllLines(FilePath, _cash);
            }
            catch (Exception exception)
            {
                Debug.Log($"Error while saving calculator cash: {exception.Message}");
            }
        }

        private void LoadCurrentInput()
        {
            CurrentInput = PlayerPrefs.GetString(CurrentInputSaveId, string.Empty);
        }
    }
}