using System.Collections.ObjectModel;

namespace GetStartedApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    public ObservableCollection<Person> Items { get; set; } = GetPersons();

    private static ObservableCollection<Person> GetPersons()
    {
        return new ObservableCollection<Person>
        {
            new Person { Name = "John Doe", Age = 30, Address = "123 Main St" },
            new Person { Name = "Jane Smith", Age = 25, Address = "456 Elm St" },
            new Person { Name = "Bob Johnson", Age = 40, Address = "789 Oak St" }
        };
    }
}


public class Person
{
    public string Name { get; set; }
    public int    Age  { get; set; }
    public string Address { get; set; }
}