<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web.aspx.cs" Inherits="web_no_api.Web" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính tiền máy tính</title>
    <link href="styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <div class="content-wrapper">
            <h2 class="title">Tính tiền máy tính</h2>
            
            <div class="input-group">
                <label >Số giờ chơi:</label>
                <asp:TextBox ID="gio" runat="server" CssClass="input-box" ></asp:TextBox>
            </div>

            <div class="input-group">
                <label>Loại máy:</label>
               <div class="checkbox-group">
                    <asp:RadioButton ID="thuong" runat="server" CssClass="checkbox" Text="Máy thường (15.000đ/giờ)" GroupName="LoaiMay" />
                    <asp:RadioButton ID="vip" runat="server" CssClass="checkbox" Text="Máy VIP (20.000đ/giờ)" GroupName="LoaiMay" />
                </div>

            </div>

            <div class="input-group">
                <label>Sử dụng điều hòa:</label>
                <asp:CheckBox ID="dieuhoa" runat="server" CssClass="checkbox" Text="Điều hòa (5.000đ/giờ)" />
            </div>

            <div class="input-group">
                <asp:Button ID="tinhtien" runat="server" CssClass="btn-calculate" Text="Tính tiền" OnClick="tinhtien_Click" />
            </div>
            <div id="phaitra" runat="server"></div>
        </div>
    </form>
</body>
</html>
