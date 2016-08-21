using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace nsabt
{
    #region interface classes
    public interface intreg
    {
        int regcod
        {
            get;
            set;
        }
        string regeml
        {
            get;
            set;
        }
        string regpwd
        {
            get;
            set;
        }
        DateTime regdat
        {
            get;
            set;
        }
    }
    public interface intprf
    {
        int prfcod
        {
            get;
            set;
        }
        int prfregcod
        {
            get;
            set;
        }
        string prffrstnam
        {
            get;
            set;
        }
        string prflstnam
        {
            get;
            set;
        }
        string prfbio
        {
            get;
            set;
        }
        string prfpic
        {
            get;
            set;
        }
        string prfbckpic
        {
            get;
            set;
        }
        char prfprvsts
        {
            get;
            set;
        }



    }
    public interface intprflnk
    {
        int prflnkcod
        {
            get;
            set;
        }
        int prflnkprfcod
        {
            get;
            set;
        }
        string prflnksit
        {
            get;
            set;
        }
        string prflnkurl
        {
            get;
            set;
        }


    }
    public interface intfav
    {
        int favcod
        {
            get;
            set;
        }
        int favprfcod
        {
            get;
            set;
        }
        int favfavprfcod
        {
            get;
            set;
        }
    }
    public interface intblg
    {
        int blgcod
        {
            get;
            set;
        }
        int blgprfcod
        {
            get;
            set;
        }
        string blghed
        {
            get;
            set;
        }
        string blgimg
        {
            get;
            set;
        }
        string blgdsc
        {
            get;
            set;
        }
        DateTime blgdat
        {
            get;
            set;
        }
    }
    #endregion

    #region property classes
    public class clsregprp : intreg
    {
        private Int32 prvregcod;
        private string prvregeml, prvregpwd;
        private DateTime prvregdat;

        public int regcod
        {
            get
            {
                return prvregcod;
            }

            set
            {
                prvregcod = value;
            }
        }

        public DateTime regdat
        {
            get
            {
                return prvregdat;
            }

            set
            {
                prvregdat = value;
            }
        }

        public string regeml
        {
            get
            {
                return prvregeml;
            }

            set
            {
                prvregeml = value;
            }
        }

        public string regpwd
        {
            get
            {
                return prvregpwd;
            }

            set
            {
                prvregpwd = value;
            }
        }
    }
    public class clsprfprp : intprf
    {
        private Int32 prvprfcod, prvprfregcod;
        private string prvprffrstnam, prvprflstnam, prvprfbio, prvprfpic, prvprfbckpic;
        private char prvprfprvsts;

        public string prfbckpic
        {
            get
            {
                return prvprfbckpic;
            }

            set
            {
                prvprfbckpic = value;
            }
        }

        public string prfbio
        {
            get
            {
                return prvprfbio;
            }

            set
            {
                prvprfbio = value;
            }
        }

        public int prfcod
        {
            get
            {
                return prvprfcod;
            }

            set
            {
                prvprfcod = value;
            }
        }

        public string prffrstnam
        {
            get
            {
                return prvprffrstnam;
            }

            set
            {
                prvprffrstnam = value;
            }
        }

        public string prflstnam
        {
            get
            {
                return prvprflstnam;
            }

            set
            {
                prvprflstnam = value;
            }
        }

        public string prfpic
        {
            get
            {
                return prvprfpic;
            }

            set
            {
                prvprfpic = value;
            }
        }

        public char prfprvsts
        {
            get
            {
                return prvprfprvsts;
            }

            set
            {
                prvprfprvsts = value;
            }
        }

        public int prfregcod
        {
            get
            {
                return prvprfregcod;
            }

            set
            {
                prvprfregcod = value;
            }
        }
    }
    public class clsprflnkprp : intprflnk
    {
        private Int32 prvprflnkcod, prvprflnkprfcod;
        private string prvprflnksit, prvprflnkurl;
        public int prflnkcod
        {
            get
            {
                return prvprflnkcod;
            }

            set
            {
                prvprflnkcod = value;
            }
        }

        public int prflnkprfcod
        {
            get
            {
                return prvprflnkprfcod;
            }

            set
            {
                prvprflnkprfcod = value;
            }
        }

        public string prflnksit
        {
            get
            {
                return prvprflnksit;
            }

            set
            {
                prvprflnksit = value;
            }
        }

        public string prflnkurl
        {
            get
            {
                return prvprflnkurl;
            }

            set
            {
                prvprflnkurl = value;
            }
        }
    }
    public class clsfavprp : intfav
    {
        private Int32 prvfavcod, prvfavprfcod, prvfavfavprfcod;
        public int favcod
        {
            get
            {
                return prvfavcod;
            }

            set
            {
                prvfavcod = value;
            }
        }

        public int favfavprfcod
        {
            get
            {
                return prvfavfavprfcod;
            }

            set
            {
                prvfavfavprfcod = value;
            }
        }

        public int favprfcod
        {
            get
            {
                return prvfavprfcod;
            }

            set
            {
                prvfavprfcod = value;
            }
        }
    }
    public class clsblgprp : intblg
    {
        public int blgcod { get; set; }
        public int blgprfcod { get; set; }
        public string blghed { get; set; }
        public string blgimg { get; set; }
        public string blgdsc { get; set; }
        public DateTime blgdat { get; set; }
    }
    #endregion

    #region Abstract class

    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        }
    }
    #endregion

    #region Main classes
    public class clsreg : clscon
    {
        public Int32 logincheck(clsregprp p)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 100).Value = p.regeml;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 100).Value = p.regpwd;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }

        public void save_rec(clsregprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regeml", SqlDbType.VarChar, 50).Value = p.regeml;
            cmd.Parameters.Add("@regpwd", SqlDbType.VarChar, 50).Value = p.regpwd;
            cmd.Parameters.Add("@regdat", SqlDbType.DateTime).Value = p.regdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsregprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = p.regcod;
            cmd.Parameters.Add("@regeml", SqlDbType.VarChar, 50).Value = p.regeml;
            cmd.Parameters.Add("@regpwd", SqlDbType.VarChar, 50).Value = p.regpwd;
            cmd.Parameters.Add("@regdat", SqlDbType.DateTime).Value = p.regdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsregprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = p.regcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsregprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsregprp> obj = new List<clsregprp>();
            while (dr.Read())
            {
                clsregprp x = new clsregprp();
                x.regcod = Convert.ToInt32(dr[0]);
                x.regeml = dr[1].ToString();
                x.regpwd = dr[2].ToString();
                x.regdat = Convert.ToDateTime(dr[3]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clsregprp> find_rec(Int32 regcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsregprp> obj = new List<clsregprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsregprp x = new clsregprp();
                x.regcod = Convert.ToInt32(dr[0]);
                x.regeml = dr[1].ToString();
                x.regpwd = dr[2].ToString();
                x.regdat = Convert.ToDateTime(dr[3]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsprf : clscon
    {
        public Int32 save_rec(clsprfprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfregcod", SqlDbType.Int).Value = p.prfregcod;
            cmd.Parameters.Add("@prffrstnam", SqlDbType.VarChar, 100).Value = p.prffrstnam;
            cmd.Parameters.Add("@prflstnam", SqlDbType.VarChar, 100).Value = p.prflstnam;
            cmd.Parameters.Add("@prfbio", SqlDbType.NVarChar, 2000).Value = p.prfbio;
            cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = p.prfpic;
            cmd.Parameters.Add("@prfbckpic", SqlDbType.VarChar, 50).Value = p.prfbckpic;
            cmd.Parameters.Add("@prfprvsts", SqlDbType.Char, 1).Value = p.prfprvsts;
            cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection
                                                                .ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@ret"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clsprfprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.prfcod;
            cmd.Parameters.Add("@prfregcod", SqlDbType.Int).Value = p.prfregcod;
            cmd.Parameters.Add("@prffrstnam", SqlDbType.VarChar, 100).Value = p.prffrstnam;
            cmd.Parameters.Add("@prflstnam", SqlDbType.VarChar, 100).Value = p.prflstnam;
            cmd.Parameters.Add("@prfbio", SqlDbType.NVarChar, 2000).Value = p.prfbio;
            cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = p.prfpic;
            cmd.Parameters.Add("@prfbckpic", SqlDbType.VarChar, 50).Value = p.prfbckpic;
            cmd.Parameters.Add("@prfprvsts", SqlDbType.Char, 1).Value = p.prfprvsts;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsprfprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.prfcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprfprp> srcprf(String srcstr, Int32 cod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("srcprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@srcstr", SqlDbType.VarChar, 100).Value = srcstr;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprfprp> obj = new List<clsprfprp>();
            while (dr.Read())
            {
                clsprfprp x = new clsprfprp();
                x.prfcod = Convert.ToInt32(dr[0]);
                x.prfregcod = Convert.ToInt32(dr[1]);
                x.prffrstnam = dr[2].ToString();
                x.prflstnam = dr[3].ToString();
                x.prfbio = dr[5].ToString();
                x.prfpic = dr[4].ToString();
                //x.prfbckpic = dr[6].ToString();
                //x.prfprvsts = Convert.ToChar(dr[7]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clsprfprp> find_rec(Int32 prfcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprf", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prfcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprfprp> obj = new List<clsprfprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsprfprp x = new clsprfprp();
                x.prfcod = Convert.ToInt32(dr[0]);
                x.prfregcod = Convert.ToInt32(dr[1]);
                x.prffrstnam = dr[2].ToString();
                x.prflstnam = dr[3].ToString();
                x.prfbio = dr[4].ToString();
                x.prfpic = dr[5].ToString();
                x.prfbckpic = dr[6].ToString();
                x.prfprvsts = Convert.ToChar(dr[7]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsprflnk : clscon
    {
        public void save_rec(clsprflnkprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprflnk", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prflnkprfcod", SqlDbType.Int).Value = p.prflnkprfcod;
            cmd.Parameters.Add("@prflnksit", SqlDbType.VarChar, 100).Value = p.prflnksit;
            cmd.Parameters.Add("@prflnkurl", SqlDbType.VarChar, 200).Value = p.prflnkurl;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsprflnkprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprflnk", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prflnkcod", SqlDbType.Int).Value = p.prflnkcod;
            cmd.Parameters.Add("@prflnkprfcod", SqlDbType.Int).Value = p.prflnkprfcod;
            cmd.Parameters.Add("@prflnksit", SqlDbType.VarChar, 100).Value = p.prflnksit;
            cmd.Parameters.Add("@prflnkurl", SqlDbType.VarChar, 200).Value = p.prflnkurl;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsprflnkprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprflnk", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prflnkcod", SqlDbType.Int).Value = p.prflnkcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprflnkprp> disp_rec(Int32 prfcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspprflnk", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = prfcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprflnkprp> obj = new List<clsprflnkprp>();
            while (dr.Read())
            {
                clsprflnkprp x = new clsprflnkprp();
                x.prflnkcod = Convert.ToInt32(dr[0]);
                x.prflnkprfcod = Convert.ToInt32(dr[1]);
                x.prflnksit = dr[2].ToString();
                x.prflnkurl = dr[3].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clsprflnkprp> find_rec(Int32 prflnkcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprflnk", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prflnkcod", SqlDbType.Int).Value = prflnkcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprflnkprp> obj = new List<clsprflnkprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsprflnkprp x = new clsprflnkprp();
                x.prflnkcod = Convert.ToInt32(dr[0]);
                x.prflnkprfcod = Convert.ToInt32(dr[1]);
                x.prflnksit = dr[2].ToString();
                x.prflnkurl = dr[3].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsfav : clscon
    {

        public DataSet favprf(Int32 regcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("favprf", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@regcod", SqlDbType.Int).Value
                           = regcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public void save_rec(clsfavprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insfav", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favprfcod", SqlDbType.Int).Value = p.favprfcod;
            cmd.Parameters.Add("@favfavprfcod", SqlDbType.Int).Value = p.favfavprfcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsfavprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updfav", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favcod", SqlDbType.Int).Value = p.favcod;
            cmd.Parameters.Add("@favprfcod", SqlDbType.Int).Value = p.favprfcod;
            cmd.Parameters.Add("@favfavprfcod", SqlDbType.Int).Value = p.favfavprfcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsfavprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delfav", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favcod", SqlDbType.Int).Value = p.favcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }
        public List<clsfavprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspfav", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsfavprp> obj = new List<clsfavprp>();
            while (dr.Read())
            {
                clsfavprp x = new clsfavprp();
                x.favcod = Convert.ToInt32(dr[0]);
                x.favprfcod = Convert.ToInt32(dr[1]);
                x.favfavprfcod = Convert.ToInt32(dr[2]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public List<clsfavprp> find_rec(Int32 favcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndfav", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favcod", SqlDbType.Int).Value = favcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsfavprp> obj = new List<clsfavprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsfavprp x = new clsfavprp();
                x.favcod = Convert.ToInt32(dr[0]);
                x.favprfcod = Convert.ToInt32(dr[1]);
                x.favfavprfcod = Convert.ToInt32(dr[2]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
    }
    public class clsblg : clscon
    {
        public Int32 save_rec(clsblgprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insblg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bpcod", SqlDbType.Int).Value = p.blgprfcod;
            cmd.Parameters.Add("@bhed", SqlDbType.VarChar, 100).Value = p.blghed;
            cmd.Parameters.Add("@bimg", SqlDbType.VarChar, 50).Value = p.blgimg;
            cmd.Parameters.Add("@bdsc", SqlDbType.NVarChar, -1).Value = p.blgdsc;
            cmd.Parameters.Add("@bdat", SqlDbType.DateTime).Value = p.blgdat;
            cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@ret"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clsblgprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updblg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bcod", SqlDbType.Int).Value = p.blgcod;
            cmd.Parameters.Add("@bpcod", SqlDbType.Int).Value = p.blgprfcod;
            cmd.Parameters.Add("@bhed", SqlDbType.VarChar, 100).Value = p.blghed;
            cmd.Parameters.Add("@bimg", SqlDbType.VarChar, 100).Value = p.blgimg;
            cmd.Parameters.Add("@bdsc", SqlDbType.NVarChar, 2000).Value = p.blgdsc;
            cmd.Parameters.Add("@bdat", SqlDbType.DateTime).Value = p.blgdat;
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsblgprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delblg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bcod", SqlDbType.Int).Value = p.blgcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsblgprp> disp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspblg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsblgprp> obj = new List<clsblgprp>();
            while (dr.Read())
            {
                clsblgprp x = new clsblgprp();
                x.blgcod = Convert.ToInt32(dr[0]);
                x.blgprfcod = Convert.ToInt32(dr[1]);
                x.blghed = (dr[2]).ToString();
                x.blgimg = dr[3].ToString();
                x.blgdsc = dr[4].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsblgprp> find_rec(Int32 blgcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndblg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bcod", SqlDbType.Int).Value = blgcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsblgprp> obj = new List<clsblgprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsblgprp x = new clsblgprp();
                x.blgcod = Convert.ToInt32(dr[0]);
                x.blgprfcod = Convert.ToInt32(dr[1]);
                x.blghed = dr[2].ToString();
                x.blgimg = dr[3].ToString();
                x.blgdsc = dr[4].ToString();
                x.blgdat = Convert.ToDateTime(dr[5]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsblgprp> recblg(Int32 cod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("recfndblg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsblgprp> obj = new List<clsblgprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsblgprp x = new clsblgprp();
                x.blgcod = Convert.ToInt32(dr[0]);
               // x.blgprfcod = Convert.ToInt32(dr[1]);
                x.blghed = dr[1].ToString();
                x.blgimg = dr[2].ToString();
                x.blgdsc = dr[3].ToString();
                x.blgdat = Convert.ToDateTime(dr[4]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    #endregion
}











