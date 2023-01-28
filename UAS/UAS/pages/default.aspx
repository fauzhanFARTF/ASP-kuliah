<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="UAS._default1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center><h3>INPUT DATA RENTAL MOBIL</h3></center>
     <table style="width:100%; font-family: Arial;">
        <tr>
            <td style="width: 319px; height: 26px;">NO POLISI</td>
            <td style="width: 25px; height: 26px;">:</td>
            <td style="height: 26px">
                <asp:TextBox ID="TextBox1" runat="server" Width="246px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 319px; height: 28px;">MERK MOBIL</td>
            <td style="width: 25px; height: 28px;">:</td>
            <td style="height: 28px">
                <asp:TextBox ID="TextBox2" runat="server" Width="248px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 319px; height: 28px;">
                &nbsp;</td>
            <td style="width: 25px; height: 28px;"></td>
            <td style="height: 28px">
                <asp:Button ID="btnlogin" runat="server" Text="Simpan" />
                <asp:Button ID="btnbatal" runat="server" Text="Laporan" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
