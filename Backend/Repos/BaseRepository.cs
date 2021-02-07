
using System.Data;
using Npgsql;


public class BaseRepository
{
    // Generate new connection based on connection string
    private NpgsqlConnection SqlConnection()
    {
        // This builds a connection string from our separate credentials
        // TODO: add your connection settings
        var stringBuilder = new NpgsqlConnectionStringBuilder
        {
            Host = "ec2-34-254-69-72.eu-west-1.compute.amazonaws.com", // e.g. ec2-1-2-3-4@eu-west-1.compute.amazonaws.com
            Database = "deo1hief8hjehb", // e.g. ksdjfhsafnfas
            Username = "umkcoficnhbhkz", // e.g. lksfhdslkfsdflk
            Password = "38c7c8aa5a21b9240b83bfe26f009bcac560aa4e344af14482760785444ddf92",// e.g KJZDldfj34567dslkfjsdlfksdjflsdkfjsdlkfjsdl34567fkjdsgDRTYUI
            Port = 5432, // e.g 5432
            SslMode = Npgsql.SslMode.Require, // Heroku Specific Setting
            TrustServerCertificate = true // Heroku Specific Setting
        };

        return new NpgsqlConnection(stringBuilder.ConnectionString);
    }

    // Open new connection and return it for use
    public IDbConnection CreateConnection()
    {
        var connection = SqlConnection();
        connection.Open();
        return connection;
    }

}