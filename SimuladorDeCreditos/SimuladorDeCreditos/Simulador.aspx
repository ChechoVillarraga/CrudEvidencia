<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simulador.aspx.cs" Inherits="SimuladorDeCreditos.Simulador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LMonto" runat="server" Text="Monto:"></asp:Label>
        <asp:TextBox ID="TBmonto" runat="server" Width="213px"></asp:TextBox>
    <asp:Label ID="LTipoCredito" runat="server" Text="Tipo Credito:"></asp:Label>

        <asp:DropDownList ID="DDLTipoCredito" runat="server" AutoPostBack="True">
            <asp:ListItem>Hipotecario</asp:ListItem>
            <asp:ListItem>Vehiculo</asp:ListItem>
            <asp:ListItem>Consumo</asp:ListItem>
        </asp:DropDownList>
    </div>
        <div>
            <asp:Label ID="LPLazo" runat="server" Text="Plazo:"></asp:Label>
        <asp:TextBox ID="TBPlazo" runat="server" Width="213px"></asp:TextBox>
            <asp:Button ID="BCalcular" runat="server" Text="Calcular!" OnClick="BCalcular_Click" />
        </div>
        <div>
            <asp:GridView ID="GVtabla" runat="server"></asp:GridView>

        </div>
        
    </form>
</body>
</html>
