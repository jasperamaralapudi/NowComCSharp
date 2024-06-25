using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical programs menu:");
        Console.WriteLine("1. Calculate Sum");
        Console.WriteLine("2. Calculate Difference");
        Console.WriteLine("3. Calculate Product");
        Console.WriteLine("4. Calculate Division");
        Console.WriteLine("5. Check Prime Number");
        Console.WriteLine("6. Swap Numbers");
        Console.WriteLine("7. Check Palindrome");
        Console.WriteLine("8. Generate Fibonacci Series");
        Console.WriteLine("9. Calculate Factorial");
        Console.WriteLine("10. Check Armstrong Number");
        Console.WriteLine("11. Calculate Sum of Digits");
        Console.WriteLine("12. Check Leap Year");
        Console.WriteLine("13. Find Largest Number in an Array");
        Console.WriteLine("14. Reverse a String");
        System.Console.WriteLine("15. No. of words in a string.");
        System.Console.WriteLine("16. Length of a string");
        System.Console.WriteLine("17. Convert the string into lower case.");
        System.Console.WriteLine("18. Convert the string into upper case.");
        System.Console.WriteLine("19. Convert the string into pascal case.");
        System.Console.WriteLine("20. Unique characters in the string");
        System.Console.WriteLine("21. Duplicates in the string");
        System.Console.WriteLine("22. Number to Roman");
        System.Console.WriteLine("23. Pattern 1");
        System.Console.WriteLine("24. Pattern 2");
        System.Console.WriteLine("25. Pattern 3");
        System.Console.WriteLine("26. Pattern 4");
        System.Console.WriteLine("27. Pattern 5");
        System.Console.WriteLine("28. Pattern 6");
        System.Console.WriteLine("29. Pattern 7");
        System.Console.WriteLine("30. Pattern 8");
        System.Console.WriteLine("31. Pattern 9");
        System.Console.WriteLine("32. Pattern 10");
        System.Console.WriteLine("33. Pattern 11");
        System.Console.WriteLine("34. Bubble Sort");
        System.Console.WriteLine("35. Selection Sort");
        System.Console.WriteLine("36. Insertion Sort");
        System.Console.WriteLine("37. Shell Sort");
        System.Console.WriteLine("38. Quick Sort");
        Console.WriteLine("39. Public access modifier");
        System.Console.WriteLine("40. Private access modifier");
        System.Console.WriteLine("41. Protected access modifier");
        System.Console.WriteLine("42. Internal access modifier");
        System.Console.WriteLine("43. Protected internal access modifier");
        Console.WriteLine("44. IOException");
        Console.WriteLine("45. IndexOutOfRangeException");
        Console.WriteLine("46. ArrayTypeMismatchException");
        Console.WriteLine("47. NullReferenceException");
        Console.WriteLine("48. DivideByZeroException");
        Console.WriteLine("49. InvalidCastException");
        Console.WriteLine("50. OutOfMemoryException");
        Console.WriteLine("51. StackOverflowException");
        Console.WriteLine("52. Exit");
        while (true)
        {
            Console.Write("Enter your choice : ");
            int choice = int.Parse(System.Console.ReadLine());
            int num1 = 10;
            int num2 = 20;
            switch (choice)
            {
                case 1:
                    Sum sumInstance = new Sum();
                    sumInstance.CalculateSum(num1, num2);
                    break;
                case 2:
                    Difference diffInstance = new Difference();
                    diffInstance.calculateDifference(num1, num2);
                    break;
                case 3:
                    Product productInstance= new Product();
                    productInstance.CalculateProduct(num1, num2);

                    break;
                case 4:
                    Division divisionInstance= new Division();
                    divisionInstance.CalculateDivision(num1, num2);
                    break;
                case 5:
                    Prime primeInstance=new Prime();
                    primeInstance.isPrime();
                    break;
                case 6:
                    SwapNumbers swapInstance=new SwapNumbers();
                    swapInstance.Swap(num1, num2);
                    break;
                case 7:
                    Palindrome palindromeInstance=new Palindrome();
                    palindromeInstance.isPalindrome();
                    break;
                case 8:
                    Fibonacci fibInstance=new Fibonacci();
                    fibInstance.Fib();
                    break;
                case 9:
                    Factorial factInstance=new Factorial();
                    factInstance.Fact();
                    break;
                case 10:
                    Armstrong armstrongInstance=new Armstrong();
                    armstrongInstance.isArmstrong();
                    break;
                case 11:
                    SumOfDigits sumInstance1=new SumOfDigits();
                    sumInstance1.Sum();
                    break;
                case 12:
                    LeapYear leapInstance=new LeapYear();
                    leapInstance.isLeap();
                    break;
                case 13:
                    LargeNumInArr largeInstance=new LargeNumInArr();
                    largeInstance.largeNum();
                    break;
                case 14:
                    reverseString reverseInstance=new reverseString();
                    reverseInstance.reverse1();
                    break;
                case 15:
                    NoOfWords numberInstance=new NoOfWords();
                    numberInstance.count1();
                    break;
                case 16:
                    LengthString lengthInstance=new LengthString();
                    lengthInstance.lengthOfString();
                    break;
                case 17:
                    LowerCase lowerInstance=new LowerCase();
                    lowerInstance.lowerCase();
                    break;
                case 18:
                    UpperCase upperInstance=new UpperCase();
                    upperInstance.upperCase();
                    break;
                case 19:
                    PascalCase pascalInstance=new PascalCase();
                    pascalInstance.pascalCase();
                    break;
                case 20:
                    UniqueCharacters uniqueInstance=new UniqueCharacters();
                    uniqueInstance.uniqueCharacters();
                    break;
                case 21:
                    DuplicateChars duplicateInstance=new DuplicateChars();
                    duplicateInstance.duplicateChars();
                    break;
                case 22:
                    NumToRoman romanInstance=new NumToRoman();
                    romanInstance.numToRoman();
                    break;
                case 23:
                    Pattern1 pattern1Instance=new Pattern1();
                    pattern1Instance.pattern1();
                    break;
                case 24:
                    Pattern2 pattern2Instance=new Pattern2();
                    pattern2Instance.pattern2();
                    break;
                case 25:
                    Pattern3 pattern3Instance=new Pattern3();
                    pattern3Instance.pattern3();
                    break;
                case 26:
                    Pattern4 pattern4Instance=new Pattern4();
                    pattern4Instance.pattern4();
                    break;
                case 27:
                    Pattern5 pattern5Instance=new Pattern5();
                    pattern5Instance.pattern5();
                    break;
                case 28:
                    Pattern6 pattern6Instance=new Pattern6();
                    pattern6Instance.pattern6();
                    break;
                case 29:
                    Pattern7 pattern7Instance=new Pattern7();
                    pattern7Instance.pattern7();
                    break;
                case 30:
                    Pattern8 pattern8Instance=new Pattern8();
                    pattern8Instance.pattern8();
                    break;
                case 31:
                    Pattern9 pattern9Instance=new Pattern9();
                    pattern9Instance.pattern9();
                    break;
                case 32:
                    Pattern10 pattern10Instance=new Pattern10();
                    pattern10Instance.pattern10();
                    break;
                case 33:
                    Pattern11 pattern11Instance=new Pattern11();
                    pattern11Instance.pattern11();
                    break;
                case 34:
                    BubbleSort bubbleInstance=new BubbleSort();
                    bubbleInstance.bubbleSort();
                    break;
                case 35:
                    SelectionSort selectionSortInstance=new SelectionSort();
                    selectionSortInstance.selectionSort();
                    break;
                case 36:
                    InsertionSort insertionSortInstance=new InsertionSort();
                    insertionSortInstance.insertionSort();
                    break;
                case 37:
                    ShellSort shellSortInstance=new ShellSort();
                    shellSortInstance.shellSort();
                    break;
                case 38:
                    MergeSort mergeSortInstance=new MergeSort();
                    mergeSortInstance.mergeSort();
                    break;
                case 39:
                    MyClassPublic obj1 = new MyClassPublic();
                    obj1.PublicMethod();
                    break;
                case 40:
                    MyClassPrivate obj2 = new MyClassPrivate();
                    // obj2.PrivateMethod();  // Cannot access private method directly
                    obj2.AccessPrivateMethod();  // Accessing through a public method
                    break;
                case 41:
                    MyDerivedClass obj3 = new MyDerivedClass();
                    // obj3.ProtectedMethod();  // Cannot access protected method directly
                    obj3.AccessProtectedMethod();  // Accessing through a public method
                    break;
                case 42:
                    MyClassInternal obj4 = new MyClassInternal();
                    obj4.InternalMethod();  // Accessing internal method
                    break;
                case 43:
                    MyBaseClass2 obj5 = new MyBaseClass2();
                    obj5.ProtectedInternalMethod();  // Accessing protected internal method
                    break;
                case 44:
                    IOExceptionExample ioExceptionInstance = new IOExceptionExample();
                    ioExceptionInstance.TriggerIOException();
                    //TriggerIOException();
                    break;
                case 45:
                    IndexOutOfRangeExceptionExample indexOutOfRangeInstance = new IndexOutOfRangeExceptionExample();
                    indexOutOfRangeInstance.TriggerIndexOutOfRangeException();
                    break;
                case 46:
                    ArrayTypeMismatchExceptionExample arrayTypeMismatchInstance = new ArrayTypeMismatchExceptionExample();
                    arrayTypeMismatchInstance.TriggerArrayTypeMismatchException();
                    break;
                case 47:
                    NullReferenceExceptionExample nullReferenceInstance = new NullReferenceExceptionExample();
                    nullReferenceInstance.TriggerNullReferenceException();
                    break;
                case 48:
                    DivideByZeroExceptionExample divideByZeroInstance = new DivideByZeroExceptionExample();
                    divideByZeroInstance.TriggerDivideByZeroException();
                    break;
                case 49:
                    InvalidCastExceptionExample invalidCastInstance = new InvalidCastExceptionExample();
                    invalidCastInstance.TriggerInvalidCastException();
                    break;
                case 50:
                    OutOfMemoryExceptionExample outOfMemoryInstance = new OutOfMemoryExceptionExample();
                    outOfMemoryInstance.TriggerOutOfMemoryException();
                    break;
                case 51:
                    StackOverflowExceptionExample stackOverflowInstance = new StackOverflowExceptionExample();
                    stackOverflowInstance.TriggerStackOverflowException();
                    break;
                case 52:
                    Console.WriteLine("Exiting program.");
                    return;

            }
        }
    }
}