namespace Architecture.Services.Interfaces
{
    public interface ICalculatorCashService
    {
        string CurrentInput { get; }
        void Cash(string data);
        void CashCurrentInput(string input);
        string GetCash();
        void Load();
        void Clear();
    }
}