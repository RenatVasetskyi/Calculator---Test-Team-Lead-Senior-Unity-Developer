using Business.Architecture.States.Interfaces;
using Business.CalculatorProgram.Business;
using Business.CalculatorProgram.Interfaces;
using UnityEngine;
using Zenject;

namespace Mono
{
    public class Menu : MonoBehaviour 
    {
        [SerializeField] private MenuView _view;

        private IStateMachine _stateMachine;
        private IMenu _model;
        
        [Inject]
        public void Inject(IStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        
        private void Awake()
        {
            _model = new MenuModel(_stateMachine);
        }

        private void OnEnable()
        {
            _view.PlayButton.onClick.AddListener(EnterCalculatorProgram);
        }

        private void OnDisable()
        {
            _view.PlayButton.onClick.RemoveListener(EnterCalculatorProgram);
        }

        private void EnterCalculatorProgram()
        {
            _model.EnterCalculatorProgram();
        }
    }
}