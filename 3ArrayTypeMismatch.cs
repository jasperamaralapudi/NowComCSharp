class ArrayTypeMismatchExceptionExample {
    public void TriggerArrayTypeMismatchException() {
        try {
            object[] arr = new string[5];
            arr[0] = 10; // This will throw ArrayTypeMismatchException
        } catch (ArrayTypeMismatchException e) {
            Console.WriteLine("Caught ArrayTypeMismatchException: " + e.Message);
        }
    }
}
