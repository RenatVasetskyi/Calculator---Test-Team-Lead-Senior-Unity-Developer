using System;
using Menu.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    [Serializable]
    public class MenuView : IMenuView
    {
        [SerializeField] private Button _playButton;
        public Button PlayButton => _playButton;
    }
}