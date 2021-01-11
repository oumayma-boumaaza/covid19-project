using System;
using System.Data.SqlClient;

namespace EtatCovid.persistance
{
    public static class LiasonDB
    {
        static string chaine = @"Data Source=localhost;Initial Catalog=Covid19;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        public static SqlConnection cnx = new SqlConnection(chaine);
        public static SqlCommand cmd = new SqlCommand();
        public static void InsertCitoyen(Citoyen citoyen)   
        {
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = $"insert into Citoyen(CIN, NOM,PRENOM,DATEDE NAISSANCE,ETAT) values('{citoyen.cin}','{citoyen.last}','{citoyen.first}','{citoyen.dateDeNaissaance.ToShortDateString()}','{citoyen.etat}') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnx.Close();
                
            }

        }
         public static void InsertLabo(Labo labo)
        {
            try
            {
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
                cnx.Close();
                
            }

        }
        public static void InsertCentre(CentreDeVaccination centreDeVaccination)
        {
            try
            {
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
                cnx.Close();

            }

        }
        public static void InsertEnregistrementTest(EnregistrementLabo enregistrementLabo)
        {
            try
            {
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
                cnx.Close();

            }

        }
        public static void InsertEnregistrementVaccins(EnregistrementsVaccin enregistrementsVaccin)
        {
            try
            {
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
                cnx.Close();

            }

        }
        public static void InsertEnregistrementRencontre(EnregistrementsRencontres enregistrementsRencontres)
        {
            try
            {
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
                cnx.Close();

            }

        }
        public static void InsertEnregistrementEtat(EnregistrementsEtat enregistrementsEtat)
        {
            try
            {
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
                cnx.Close();

            }

        }
        public static void InsertConfinement(Confinement confinement)
        {
            try
            {
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
                cnx.Close();

            }

        }
    }
}
