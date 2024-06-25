class IndexOutOfRangeExceptionExample {
    public void TriggerIndexOutOfRangeException() {
        try {
            int[] arr = new int[5];
            int value = arr[10]; // This will throw IndexOutOfRangeException
        } catch (IndexOutOfRangeException e) {
            Console.WriteLine("Caught IndexOutOfRangeException: " + e.Message);
        }
    }
}
