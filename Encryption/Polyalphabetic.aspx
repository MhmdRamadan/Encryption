﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Polyalphabetic.aspx.cs" Inherits="Encryption.Polyalphabetic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <!DOCTYPE html>

   
    <link href="css/font-awesome.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <link href="css/fontawesome.min.css" rel="stylesheet" />
    <link href="css/all.css" rel="stylesheet" />
   
<div class="center-container">
	
	<div class="header-w3l">
        <br />
        <br />
        <br />
		<h1>Polyalphabetic Encryption !</h1>
	</div>

	<div class="main-content-agile">
		<div class="sub-main-w3">	
			<div class="wthree-pro">				
			</div>
            <div class="pom-agile">
					        
					&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="String"></asp:TextBox><br/>
				</div>
            <div class="pom-agile">
					        
					&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="First rule move right by "></asp:TextBox><br/>
				</div>
            <div class="pom-agile">
					        
					&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Second rule move right by"></asp:TextBox><br/>
				</div>
            <div class="pom-agile">
					        
					&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Third rule move right by"></asp:TextBox><br/>
				</div>
            
            <div class="right-w3l">
                        <asp:Button ID="Button1" runat="server" Text="Encrypt" OnClick="Button1_Click"  />
					</div>
            </div>
      </div>
      </div>
</asp:Content>

