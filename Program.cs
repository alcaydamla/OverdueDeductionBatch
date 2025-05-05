using System;
using Oracle.ManagedDataAccess.Client;

class Program
{
    static void Main(string[] args)
    {
        string connStr = @"User Id=C##CRMUSER;
                           Password=Password1!;
                           Data Source=(DESCRIPTION=
                             (ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))
                             (CONNECT_DATA=(SERVICE_NAME=ORCLPDB1)))";

        try
        {
            using var connection = new OracleConnection(connStr);
            connection.Open();
            Console.WriteLine("Oracle bağlantısı başarılı.");
            using var command = new OracleCommand("APPLY_OVERDUE_DEDUCTIONS", connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            command.ExecuteNonQuery();
            Console.WriteLine("Batch başarıyla çalıştı: Borçlar bakiyeden düşürüldü ve totaldebt sıfırlandı.");
        }
        catch (OracleException oex)
        {
            Console.WriteLine("Oracle Hatası: " + oex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Genel Hata: " + ex.ToString());
        }
    }
}
