namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.WriteLine("What database do you want: list, sql, or mongo?");
            string datatype = Console.ReadLine();

            // create the new database
            IDataAccess database = DataAccessFactory.GetDataAccessType(datatype);
            database.LoadData();
            database.SaveData();
        }
    }
}
