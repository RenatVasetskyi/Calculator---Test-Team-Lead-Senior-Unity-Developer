using CalculatorProgram.Error.Interfaces;
using UnityEngine;

namespace CalculatorProgram.Error.Business
{
    public class CalculatorErrorWindowModel : ICalculatorErrorWindowModel
    {
        public void DeleteMyself(GameObject gameObject)
        {
            Object.Destroy(gameObject);
        }
    }
}