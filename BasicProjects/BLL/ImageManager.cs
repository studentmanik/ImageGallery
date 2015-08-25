using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BasicProjects.DAL;
using BasicProjects.Modle;

namespace BasicProjects.BLL
{
    public class ImageManager
    {
        ImageGateway aImageGateway = new ImageGateway();
        public string InsertImage(Images2 image)
        {
            int message = aImageGateway.InsertImage(image);

            if (message > 0)
            {
                return "Image saved Successfully.";

            }
            else
            {
                return "Opps !!!!! Error Image is not save";
            }
        }


        public List<Images2> GetAllImage()
        {
            return aImageGateway.GetAllImage();
        }

       


    }
}