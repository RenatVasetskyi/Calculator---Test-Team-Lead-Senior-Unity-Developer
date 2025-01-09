namespace CalculatorProgram.Interfaces
{
    public interface ICalculator
    {
        string AddNumbers(string input);
        void Subscribe(ICalculatorObserver observer);
        void UnSubscribe(ICalculatorObserver observer);
    }
}