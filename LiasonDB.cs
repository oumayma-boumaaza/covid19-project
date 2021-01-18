using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EtatCovid
{
    public static class LiasonDB
    {
        static string chaine = @"Data Source=DESKTOP-F8JEVTP\SQLDEVELOPPER;Initial Catalog=Covid19;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public static List<Citoyen> citoyens;
        public static List<CentreDeVaccination> centres;
        #region  Citoyen
        public static void InsertCitoyen(Citoyen citoyen)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into Citoyen(CIN, NOM,PRENOM,[DATE DE NAISSANCE],ETAT) values('{citoyen.cin}','{citoyen.last}','{citoyen.first}','{citoyen.dateDeNaissaance.ToShortDateString()}','{(int)citoyen.Etat}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        public static void UpdateCitoyen(Citoyen citoyen)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"update Citoyen set ETAT='{(int)citoyen.Etat}' WHERE  CIN='{citoyen.cin}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
        }
        public static bool CitoyenExist(string cin)
        {
            bool resultat;
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"SELECT COUNT(*) FROM Citoyen WHERE CIN='{cin}'";
                int res = Convert.ToInt32(cmd.ExecuteScalar());
                if (res == 0)
                    resultat = false;
                else
                    resultat = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return resultat;

        }
        public static List<Citoyen> ListerCitoyens()
        {
            if (citoyens != null)
            {
                return citoyens;
            }
            citoyens = new List<Citoyen>();
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM Citoyen";

                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    citoyens.Add(new Citoyen(row["NOM"].ToString(), row["PRENOM"].ToString(), row["CIN"].ToString(),
                        DateTime.Parse(row["DATE DE NAISSANCE"].ToString()), (Etat)int.Parse(row["ETAT"].ToString())));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
            return citoyens;
        }
        #endregion
        #region Labo
        public static void InsertLabo(Labo labo)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into Laboratoire(NomLabo) values('{labo.nom}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        public static bool LaboExist(string nom)
        {
            bool resultat;
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"SELECT COUNT(*) FROM Laboratoire WHERE NomLabo='{nom}'";
                int res = Convert.ToInt32(cmd.ExecuteScalar());
                if (res == 0)
                    resultat = false;
                else
                    resultat = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return resultat;

        }
        public static List<Labo> ListerLabo()
        {
            List<Labo> labos = new List<Labo>();
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM Laboratoire";

                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    labos.Add(new Labo(row["NomLabo"].ToString()));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
            return labos;
        }
        #endregion
        #region Centre De Vaccination
        public static void InsertCentre(CentreDeVaccination centreDeVaccination)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into CentreDeVaccination(NomCentre) values('{centreDeVaccination.nomCentre}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        public static bool CentreExist(string nom)
        {
            bool resultat;
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"SELECT COUNT(*) FROM CentreDeVaccination WHERE NomCentre='{nom}'";
                int res = Convert.ToInt32(cmd.ExecuteScalar());
                if (res == 0)
                    resultat = false;
                else
                    resultat = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
            return resultat;

        }
        public static List<CentreDeVaccination> ListerCentre()
        {
            if (centres != null)
                return centres;
            centres = new List<CentreDeVaccination>();
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM CentreDeVaccination";

                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    centres.Add(new CentreDeVaccination(row["NomCentre"].ToString()));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
            return centres;
        }
        #endregion
        #region enreglaboratoire
        public static void InsertEnregistrementTest(DateTime date, string cin, bool result, string nomLabo)
        {

            int res = result ? 1 : 0;
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsLabo(DateTest,CinCitoyen,Resultat,Labo) values('{date}','{cin}','{res}','{nomLabo}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        public static List<EnregistrementLabo> ListerTests()
        {

            var tests = new List<EnregistrementLabo>();
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM EnregistrementsLabo";

                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];

                    tests.Add(new EnregistrementLabo(DateTime.Parse(row["DateTest"].ToString()),
                        row["CinCitoyen"].ToString(), (bool)row["Resultat"], row["Labo"].ToString()));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
            return tests;
        }

        #endregion
        #region enregvaccins
        public static void InsertEnregistrementVaccins(DateTime date, string cin, string centreDeVaccination)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsVaccins(DateVacc,CinCitoyen,CentreDeVaccination) values('{date}','{cin}','{centreDeVaccination}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        public static List<EnregistrementsVaccin> ListerVaccins()
        {

            var vaccins = new List<EnregistrementsVaccin>();
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM EnregistrementsVaccins";

                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];

                    vaccins.Add(new EnregistrementsVaccin(DateTime.Parse(row["DateVacc"].ToString()),
                        row["CinCitoyen"].ToString(),
                       row["CentreDeVaccination"].ToString()));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
            return vaccins;
        }
        #endregion
        #region enregRencontres
        public static void InsertEnregistrementRencontre(DateTime date, string cin1, string cin2)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsRencontres(DateRencontre,CinCitoyen1,CinCitoyen2) values('{date}','{cin1}','{cin2}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        #endregion
        #region enregEtats
        public static void InsertEnregistrementEtat(DateTime date, string cin, Etat Etat)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementEtats(DateEtat,CinCitoyen,Etat) values('{date}','{cin}','{(int)Etat}')";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
        #endregion
        public static List<EnregistrementsEtat> ListerEtats()
        {

            var etats = new List<EnregistrementsEtat>();
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT * FROM EnregistrementEtats";

                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];

                    etats.Add(new EnregistrementsEtat(DateTime.Parse(row["DateEtat"].ToString()),
                        row["CinCitoyen"].ToString(),
                        (Etat)int.Parse(row["Etat"].ToString())));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }
            return etats;
        }

        #region confinement

        public static void InsertConfinement(DateTime debut, DateTime fin, string cin)
        {
            try
            {



                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into Confinements(DateDebut,DateFin,CinCitoyen) values('{debut}','{fin}','{cin}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();

            }

        }
    }
}
#endregion
