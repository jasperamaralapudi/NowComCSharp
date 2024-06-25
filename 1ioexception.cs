using System.IO;

class IOExceptionExample {
    public void TriggerIOException() {
        try {
            using (StreamReader sr = new StreamReader("nonexistentfile.txt")) {
                string line = sr.ReadToEnd();
            }
        } catch (IOException e) {
            Console.WriteLine("Caught IOException: " + e.Message);
        }
    }
}
