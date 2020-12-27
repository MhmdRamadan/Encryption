<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Navigation.aspx.cs" Inherits="Encryption.Navigation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!DOCTYPE html>
    
    
    <link href="css/font-awesome.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <link href="css/fontawesome.min.css" rel="stylesheet" />
    <div class="center-container">
	
	<div class="header-w3l">
        <br />
        <br />
        <br />
	<h1>Options</h1>
	</div>

	<div class="main-content-agile">
	<div class="sub-main-w3">	
			
		
			       <div class="pom-agile">                                             
                    <a href="Caesar.aspx" class="btn btn-primary" role="button" aria-disabled="true" style="width: 300px">Caesar</a><br /><br />
				</div>
				<div class="pom-agile">					
                    <a href="Monoalphabetic.aspx" class="btn btn-primary" role="button" aria-disabled="true" style="width: 300px">Monoalphabetic</a><br /><br />
			
				</div>
                	<div class="pom-agile">			
                    <a href="Polyalphabetic.aspx" class="btn btn-primary" role="button" aria-disabled="true" style="width: 300px">Polyalphabetic</a><br /><br />
				

				</div>
                <div class="pom-agile">			
                    <a href="Playfair.aspx" class="btn btn-primary" role="button" aria-disabled="true" style="width: 300px">Playfair </a><br/>
				
				</div>
<br/>
				
                <div class="pom-agile">			
                    <a href="Rail fence.aspx" class="btn btn-primary" role="button" aria-disabled="true" style="width: 300px">Rail fence </a><br/>
				
				</div>
               
		
		</div>
	</div>
	
</div>
   
        <div>
        </div>
  
</asp:Content>
