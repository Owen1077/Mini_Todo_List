namespace Todo.Data
{
    public class ConnectionString
    {

            private static string cName = "Data Source=shadow\\sqlexpress;Initial Catalog=TODOLIST;Integrated Security=True";
            public static string CName { get => cName; }
        
    }
}
