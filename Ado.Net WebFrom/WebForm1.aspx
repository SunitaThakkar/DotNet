

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ado.Net_WebFrom.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <form id="form1" runat="server">
    
<asp:Label ID="lblDOJ" runat="server" Text="DOJ"></asp:Label>
<asp:Calendar runat="server" ID="DOJ" OnSelectionChanged="Unnamed1_SelectionChanged" ></asp:Calendar>
     <br />
     <asp:Label ID="Label8" runat="server" Text="EmpID"></asp:Label>
     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
         <br />
<asp:Label ID="Label1" runat="server" Text="EmpName"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <br />
 <asp:Label ID="Label3" runat="server" Text="DeptID"></asp:Label>
<asp:TextBox  ID="TextBox2" runat="server"></asp:TextBox>
         <br />
 <asp:Label ID="Label4" runat="server" Text="Salary"></asp:Label>
 <asp:TextBox  ID="TextBox3" runat="server"></asp:TextBox>
         <br />
 <asp:Label ID="Label5" runat="server" Text="WorkingPlace"></asp:Label>
       <asp:TextBox  ID="TextBox4" runat="server"></asp:TextBox>
         <br />
 <asp:Label ID="Label6" runat="server" Text="Age"></asp:Label>
     <asp:TextBox  ID="TextBox5" runat="server"></asp:TextBox>
     <br />
     <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
    
     <asp:TextBox  ID="TextBox6" runat="server"></asp:TextBox>
      <asp:Label ID="LabelSave" runat="server"  BackColor="Green"></asp:Label>
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" OnClientClick="Button_Update" />
            <asp:Button ID="Button2" runat="server" OnClick="Button_Update" Text="Update" />
        </div>
     <p>

     
     </p>
     <p>
         &nbsp;</p>
            <asp:GridView ID="GridView1" runat="server" Width="472px"></asp:GridView>
    </form>
</body>
</html>
