

using GruempeliTournier.Model;
using Microsoft.Data.SqlClient;

var list = new List<Player>();

var contetn = File.ReadAllText("Title.txt");
Console.WriteLine(contetn);

var connectionString =
    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Gruempeli;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
using (var connection = new SqlConnection(connectionString))
{
    connection.Open();

    var sql = "SELECT Id, Name, FirstName, Gender, BirthDate FROM Player;";
    using (var command = new SqlCommand(sql, connection))
    {
        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                var id = reader.GetGuid(0);
                var name = reader.GetString(1);
                var firstName = reader.GetString(2);
                var birthDate = reader.GetDateTime(4);
                var gender = reader.GetString(3);

                var player = new Player()
                {
                    Id = id,
                    Name = name,
                    FirstName = firstName,
                    BirthDate = birthDate,
                    Gender = Enum.Parse<Gender>(gender)
                };
                list.Add(player);
            }
        }
    }

}

foreach (var player in list)
{
    Console.WriteLine(player.GetFullName());
}