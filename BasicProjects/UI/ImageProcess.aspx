<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageProcess.aspx.cs" Inherits="BasicProjects.ImageProcess" %>
<%@ Import Namespace="BasicProjects.BLL" %>
<%@ Import Namespace="BasicProjects.Modle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Image</title>
    <link href="../Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrappe">
            <div id="header">

                <h3>Bangladesh</h3>
            </div>

        <div id="nav">

        </div>
            <table style="width:100%;">
               <%
                   ImageManager aImageManager = new ImageManager();
                   foreach ( Images2 images2 in aImageManager.GetAllImage())
                   {
                       %>
                
                 <tr>
                    <td><% Response.Write(images2.ImageName); %></td>
                     <td><img src="http://localhost:16157/<% Response.Write(images2.ImagePath); %>"/></td>
                    <td><% Response.Write(images2.Description); %></td>
                </tr>
                 <% }
                   
                    %>
                
               
            </table>
         <div id="Lsidebar">
             <p>
                <h2>Bangladesh </h2> 
                Country in South Asia
                Bangladesh, east of India on the Bay of Bengal, is South Asian country of lush greenery and many waterways.
                  Its Padma (Ganges), Meghna and Jamuna rivers create fertile alluvial plains, and travel by boat is common.
                  On the southern coast, the Sundarbans, an enormous mangrove forest shared with India, are home to the Royal
                  Bengal tiger.
             </p>
        </div>
        <div id="session">
            <div id="upload">  
                <asp:Label ID="Label1" runat="server" Text="Image Name"></asp:Label><br />
            <asp:TextBox ID="imageNameTextBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label><br />
            <asp:TextBox ID="descriptionTextBox" runat="server"></asp:TextBox><br />
               <asp:Label ID="Label3" runat="server" Text="Select Image Path"></asp:Label><br />
            <asp:FileUpload ID="imageFileUpload" runat="server" /><br />
            <asp:Button ID="uploadButton" runat="server" Text="Upload" OnClick="uploadButton_Click" />
            </div>
            <div id="gridview" aria-autocomplete="none">
                <asp:GridView ID="imageGridView" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="ImageName" HeaderText="Name" />
                        <asp:ImageField DataImageUrlField="Image" HeaderText="Image">
                            <ControlStyle Width="100px" Height="100px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="Discription" HeaderText="Description" />
                    </Columns>
                </asp:GridView>

            </div>
            

        </div>
       
        <div id="Rsidebar">
            <p>
               <h2>Badarganj Upazila </h2> 
From Wikipedia, the free encyclopedia
Badarganj
বদরগঞ্জ
Upazila
Badarganj is located in Bangladesh
Badarganj
Badarganj
Location in Bangladesh
Coordinates: 25°40′N 89°03′ECoordinates: 25°40′N 89°03′E
Country 	 Bangladesh
Division 	Rangpur Division
District 	Rangpur District
Area
 • Total 	301.29 km2 (116.33 sq mi)
Population (1991)
 • Total 	213,431
 • Density 	708/km2 (1,830/sq mi)
Time zone 	BST (UTC+6)
Website 	Official Map of Badarganj

Badarganj (Bengali: বদরগঞ্জ) is an Upazila of Rangpur District in the Division of Rangpur, Bangladesh.
            </p>
        </div>

        <div id="footer">
            <p><h2> Powered by &copy MrSoft Ltd Bangladesh </h2></p>

        </div>
    </div>
    </form>
</body>
</html>
