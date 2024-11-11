<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="row">
            <div>
                <asp:GridView id="MyGridView" DataSourceID="MyDataSource1" 
                    AllowSorting="true" AllowPaging="true" 
                    DataKeyNames="ProductID" 
                    AutoGenerateEditButton="true" 
                    runat="server"></asp:GridView>

                <asp:SqlDataSource ID="MyDataSource1" runat="server" ConnectionString="data source=DESKTOP-3IOUQVC\SQLEXPRESS;initial catalog=northwind;persist security info=True;Integrated Security=SSPI"
                    ProviderName="System.Data.SqlClient"
                    SelectCommand="SELECT ProductId, ProductName, UnitPrice From Products"
                    UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice where [ProductId]=@ProductId"> <!-- en data source (el nombre del server), utilizar siempre sqlexpress al final -->
                </asp:SqlDataSource>
            </div>
        </div>
    </main>

</asp:Content>
