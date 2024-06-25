class StackOverflowExceptionExample {
    public void TriggerStackOverflowException() {
        try {
            CauseStackOverflow();
        } catch (StackOverflowException e) {
            Console.WriteLine("Caught StackOverflowException: " + e.Message);
        }
    }

    public void CauseStackOverflow() {
        CauseStackOverflow(); // Recursive call to cause StackOverflowException
    }
}
