class DivideByZeroExceptionExample {
    public void TriggerDivideByZeroException() {
        try {
            int a = 10;
            int b = 0;
            int result = a / b; // This will throw DivideByZeroException
        } catch (DivideByZeroException e) {
            Console.WriteLine("Caught DivideByZeroException: " + e.Message);
        }
    }
}
