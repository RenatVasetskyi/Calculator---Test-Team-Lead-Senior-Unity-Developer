using System;
using Mono.Menu.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Mono.Menu
{
    [Serializable]
    public class MenuView : IMenuView
    {
        [SerializeField] private Button _playButton;
        public Button PlayButton => _playButton;
    }
}