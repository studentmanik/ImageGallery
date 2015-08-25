using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using BasicProjects.Modle;


namespace BasicProjects.DAL
{

   
    public class ImageGateway
    {

        String connectionDB = ConfigurationManager.ConnectionStrings["ConnectionImageDB"].ConnectionString;


        public int InsertImage(Images2 image)
        {

            SqlConnection connection = new SqlConnection(connectionDB);


            string query = "INSERT INTO tbl_Image VALUES('" + image.ImageName + "', '" + image.ImagePath + "', '" + image.Description + "')";
            //insert image
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;

        }

        public List<Images2> GetAllImage()
        {
            SqlConnection connection = new SqlConnection(connectionDB);
            string query = "SELECT * FROM tbl_Image";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader aReader = command.ExecuteReader();

            List<Images2> aImageList = new List<Images2>();
            while(aReader.Read())
            {
                Images2 aImage = new Images2();
                aImage.ImageName = aReader["ImageName"].ToString();
                aImage.ImagePath = aReader["Image"].ToString();
                aImage.Description = aReader["Discription"].ToString();

                aImageList.Add(aImage);
                
            }
            aReader.Close();
            connection.Close();
            return aImageList;

        }


    }
}