using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using BasicProjects.BLL;
using BasicProjects.Modle;


namespace BasicProjects
{
    public partial class ImageProcess : System.Web.UI.Page
    {

        ImageManager aImageManager = new ImageManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    GetAllImage();
            //}
        }


        public void GetAllImage()
        {

            imageGridView.DataSource = aImageManager.GetAllImage();
            imageGridView.DataBind();


        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            InsertImage();
        }

        public void InsertImage()

        {
            Images2 aImage = new Images2();

                aImage.ImageName = imageNameTextBox.Text;
                aImage.Description= descriptionTextBox.Text;
             

                if (imageFileUpload.HasFile)
                {
                    string extension = System.IO.Path.GetExtension(imageFileUpload.FileName);
                    if (extension.ToLower() != ".png" && extension.ToLower() != ".jpg" && extension.ToLower() != ".jpeg")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('Invalid image formet');", true);
                    }
                    else
                    {
                        aImage.ImagePath= "ImageStore/" + Path.GetFileName(imageFileUpload.PostedFile.FileName);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('Select Image file');", true);
                }
                String message = aImageManager.InsertImage(aImage);
                imageFileUpload.SaveAs(Server.MapPath("~/ImageStore/" + imageFileUpload.FileName));
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Popup", "alert('" + message + "');", true);
               // GetAllImage();
                imageNameTextBox.Text = String.Empty;
                descriptionTextBox.Text = String.Empty;
            }
        }
    
        
        
        
        
        }
