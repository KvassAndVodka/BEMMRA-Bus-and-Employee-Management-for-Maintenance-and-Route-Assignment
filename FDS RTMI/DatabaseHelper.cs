using Npgsql;
using System.Data;

public class DatabaseHelper
{
    private NpgsqlConnection conn;
    private NpgsqlCommand command;

    public DatabaseHelper(string connectionString)
    {
        conn = new NpgsqlConnection(connectionString);
    }

    public ConnectionState ConnectionState => conn.State;

    public DataTable GetData(string sql)
    {
        DataTable dt = new DataTable();
        ConnectionOpen();

        using (command = new NpgsqlCommand(sql, conn))
        {
            using (NpgsqlDataReader dr = command.ExecuteReader())
            {
                dt.Load(dr);
            }
        }

        ConnectionClose();

        return dt;
    }

    public int ExecuteNonQuery(string sql)
    {
        ConnectionOpen();

        using (command = new NpgsqlCommand(sql, conn))
        {
            int rowsAffected = command.ExecuteNonQuery();
            ConnectionClose();
            return rowsAffected;
        }
    }

    public void ConnectionOpen()
    {
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
    }

    private void ConnectionClose()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }

    public string GetRouteNameByBusID(int busID)
    {
        string sql = $"SELECT RouteName FROM ROUTE WHERE BusID = {busID}";
        DataTable dt = GetData(sql);
        if (dt.Rows.Count > 0)
        {
            return dt.Rows[0]["RouteName"].ToString();
        }
        else
        {
            return "No route assigned";
        }
    }

    public void CloseConnection()
    {
        if (conn != null && conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }
}
