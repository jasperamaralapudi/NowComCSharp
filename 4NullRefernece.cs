class NullReferenceExceptionExample {
    public void TriggerNullReferenceException() {
        try {
            string str = null;
            int len = str.Length; // This will throw NullReferenceException
        } catch (NullReferenceException e) {
            Console.WriteLine("Caught NullReferenceException: " + e.Message);
        }
    }
}