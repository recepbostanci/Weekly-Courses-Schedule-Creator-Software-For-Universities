using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Fonksiyon
/// </summary>
public class Fonksiyon
{
	public Fonksiyon()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public OleDbConnection baglan()
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=dpoy.mdb");
        baglanti.Open();
        return (baglanti);
          
    }

    public int cmd(string sqlcumle)
    {
        OleDbConnection baglan = this.baglan();
        OleDbCommand sorgu = new OleDbCommand(sqlcumle, baglan);
        int sonuc = 0;

        try
        {
            sonuc = sorgu.ExecuteNonQuery();
        }

        catch (OleDbException ex)
        {
            throw new Exception(ex.Message + " (" + sqlcumle + ")");
        }
        sorgu.Dispose();
        baglan.Close();
        baglan.Dispose();
        return (sonuc);
    }

    public DataTable GetDataTable(string sql)
    {
        OleDbConnection baglanti = this.baglan();
        OleDbDataAdapter adapter = new OleDbDataAdapter(sql, baglanti);
        DataTable dt = new DataTable();
        try
        {
            adapter.Fill(dt);
        }
        catch (OleDbException ex)
        {
            throw new Exception(ex.Message + " (" + sql + ")");
        }
        adapter.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return dt;
    }

    public DataSet GetDataSet(string sql)
    {
        OleDbConnection baglanti = this.baglan();
        OleDbDataAdapter adapter = new OleDbDataAdapter(sql, baglanti);
        DataSet ds = new DataSet();
        try
        {
            adapter.Fill(ds);
        }
        catch (OleDbException ex)
        {
            throw new Exception(ex.Message + " (" + sql + ")");
        }
        adapter.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return ds;
    }

    public DataRow GetDataRow(string sql)
    {
        DataTable table = GetDataTable(sql);
        if (table.Rows.Count == 0) return null;
        return table.Rows[0];
    }

    public string GetDataCell(string sql)
    {
        DataTable table = GetDataTable(sql);
        if (table.Rows.Count == 0) return null;
        return table.Rows[0][0].ToString();
    }
}