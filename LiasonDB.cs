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
            List<Citoyen> citoyens = new List<Citoyen>();
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
            List<CentreDeVaccination> centreDeVaccinations = new List<CentreDeVaccination>();
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
                    centreDeVaccinations.Add(new CentreDeVaccination(row["NomCentre"].ToString()));

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
            return centreDeVaccinations;
        }
        #endregion
        public static void InsertEnregistrementTest(EnregistrementLabo enregistrementLabo)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsLabo(DateTest,CinCitoyen,Resultat) values('{enregistrementLabo.DateTest}','{enregistrementLabo.CinCitoyen}','{enregistrementLabo.Resultat}') ";
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
        public static void InsertEnregistrementVaccins(EnregistrementsVaccin enregistrementsVaccin)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsVaccins(DateVacc,CinCitoyen) values('{enregistrementsVaccin.DateVacc}','{enregistrementsVaccin.CinCitoyen}') ";
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
        public static void InsertEnregistrementRencontre(EnregistrementsRencontres enregistrementsRencontres)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsRencontres(DateRencontre,CinCitoyen1,CinCitoyen2) values('{enregistrementsRencontres.DateRoncontre}','{enregistrementsRencontres.CinCitoyen1}','{enregistrementsRencontres.CinCitoyen2}') ";
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
        public static void InsertEnregistrementEtat(EnregistrementsEtat enregistrementsEtat)
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into EnregistrementsEtats(DateEtat,CinCitoyen,Etat) values('{enregistrementsEtat.DateEtat}','{enregistrementsEtat.CinCitoyen}','{enregistrementsEtat.etat}') ";
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
        public static void InsertConfinement(Confinement confinement)
        {
            try
            {



                if (cnx.State != ConnectionState.Open)
                    cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into Confinements(DateDebut,DateFin,CinCitoyen) values('{confinement.DateDebut}','{confinement.DateFin}','{confinement.CinCitoyen}') ";
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
