using SingleyLinkedListNamespace;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // add some nodes
        SingleyLinkedList sll = new SingleyLinkedList();

        sll.AddToFront("Jane", "Eare");
        sll.AddToFront("1Mark", "1Moore");
        sll.AddToFront("2Mark", "2Moore");
        sll.AddToFront("3Mark", "3Moore");
        sll.AddToFront("4Mark", "4Moore");

        List<Person> lp = sll.GetPeopleInOrder();

        foreach (Person p in lp)
        {
            Console.WriteLine($"The name of the dude is => {p.Fname} {p.Lname}");
        }


    }
}