using static System.Console;

public class Resume{
    public string _name;

    public List<Job> _jobs = new List<Job>();


    public void Display(){
        WriteLine($"Name: {_name}");
        WriteLine("Jobs:");

        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }
    }


}