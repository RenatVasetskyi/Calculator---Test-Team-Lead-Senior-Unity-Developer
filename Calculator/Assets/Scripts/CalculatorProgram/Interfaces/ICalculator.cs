namespace CalculatorProgram.Interfaces
{
    public interface ICalculator
    {
        string AddNumbers(string input);
        string GetCash();
        void SaveCurrentInput(string input);
        string GetCurrentInput();
        void Subscribe(ICalculatorObserver observer);
        void UnSubscribe(ICalculatorObserver observer);
    }
}