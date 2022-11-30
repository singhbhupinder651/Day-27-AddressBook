namespace AddressBookPractice
{
    class Program
    {
        public static void Main(string[] args)
        {


            //UC-13
            MultipleAddressBooks multipleAddressBooks = new MultipleAddressBooks();

            //adding multiple address books
            multipleAddressBooks.addAddressBook();
            multipleAddressBooks.addAddressBook();

            //adding contacts to above address books
            multipleAddressBooks.addContact();
            multipleAddressBooks.addContact();
            multipleAddressBooks.addContact();
            multipleAddressBooks.addContact();
            multipleAddressBooks.addContact();

            //sorting address books by name (alphabetically) before writing to text file
            multipleAddressBooks.SortContactsInAddressBookByComparingFullName();

            //writing to text file
            multipleAddressBooks.WriteToTextFile();
            
            //reading from text file
            MultipleAddressBooks.ReadFromTextFile();


        }
    }
}