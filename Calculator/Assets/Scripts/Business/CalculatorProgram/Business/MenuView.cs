using System;
using Business.CalculatorProgram.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Business.CalculatorProgram.Business
{
    [Serializable]
    public class MenuView : IMenuView
    {
        [SerializeField] private Button _playButton;
        public Button PlayButton => _playButton;
    }
}