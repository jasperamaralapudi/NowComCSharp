class OutOfMemoryExceptionExample {
    public void TriggerOutOfMemoryException() {
        try {
            int[] largeArray = new int[int.MaxValue]; // This will likely throw OutOfMemoryException
        } catch (OutOfMemoryException e) {
            Console.WriteLine("Caught OutOfMemoryException: " + e.Message);
        }
    }
}
