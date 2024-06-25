class InvalidCastExceptionExample {
    public void TriggerInvalidCastException() {
        try {
            object obj = "This is a string";
            int num = (int)obj; // This will throw InvalidCastException
        } catch (InvalidCastException e) {
            Console.WriteLine("Caught InvalidCastException: " + e.Message);
        }
    }
}