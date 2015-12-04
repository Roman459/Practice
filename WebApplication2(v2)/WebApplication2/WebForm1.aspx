<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #File1 {
            margin-top: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 651px">
    
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_user" DataSourceID="SqlDataSource2" EmptyDataText="Нет записей для отображения.">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID_user" HeaderText="ID" ReadOnly="True" SortExpression="ID_user" InsertVisible="False" />
                <asp:BoundField DataField="FIO_user" HeaderText="ФИО" SortExpression="FIO_user" />
                <asp:BoundField DataField="login_use" HeaderText="Логин" SortExpression="login_use" />
                <asp:BoundField DataField="age_user" HeaderText="Возрас" SortExpression="age_user" />
                <asp:BoundField DataField="phone_user" HeaderText="Телефон" SortExpression="phone_user" />
                <asp:TemplateField HeaderText ="Фото">
                    <ItemTemplate>
                        <asp:Image ID="foto_user" runat="server" ImageUrl='<%#Eval("foto_user")%>' Height ="100" Width="100" /> 
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyDatabaseConnectionString %>" DeleteCommand="DELETE FROM [Users] WHERE [ID_user] = @ID_user" InsertCommand="INSERT INTO [Users] ([FIO_user], [login_use], [age_user], [phone_user], [foto_user]) VALUES (@FIO_user, @login_use, @age_user, @phone_user, @foto_user)" SelectCommand="SELECT [ID_user], [FIO_user], [login_use], [age_user], [phone_user], [foto_user] FROM [Users]" UpdateCommand="UPDATE [Users] SET [FIO_user] = @FIO_user, [login_use] = @login_use, [age_user] = @age_user, [phone_user] = @phone_user, [foto_user] = @foto_user WHERE [ID_user] = @ID_user">
            <DeleteParameters>
                <asp:Parameter Name="ID_user" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="FIO_user" Type="String" />
                <asp:Parameter Name="login_use" Type="String" />
                <asp:Parameter Name="age_user" Type="Int32" />
                <asp:Parameter Name="phone_user" Type="String" />
                <asp:Parameter Name="foto_user" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="FIO_user" Type="String" />
                <asp:Parameter Name="login_use" Type="String" />
                <asp:Parameter Name="age_user" Type="Int32" />
                <asp:Parameter Name="phone_user" Type="String" />
                <asp:Parameter Name="foto_user" Type="String" />
                <asp:Parameter Name="ID_user" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Добавить пользователя" Width="129px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="ФИО" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Логин" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" Visible="False"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Возраст" Visible="False"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 1px; margin-top: 0px;" Visible="False"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Телефон" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Фото" Visible="False"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 0px" Visible="False" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 4px; margin-top: 8px" Text="Добавить" Visible="False" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
