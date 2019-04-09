<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Portatil.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Mantenimiento Developer</h2>
        <div>
            <table class="auto-style1">
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LaFidelitasConnectionString %>" SelectCommand="SELECT [id] FROM [Portatil]"></asp:SqlDataSource>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Marca"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="118px">
                        <asp:ListItem Value="0">HP</asp:ListItem>
                        <asp:ListItem Value="1">Lenovo</asp:ListItem>
                        <asp:ListItem Value="2">Gateway</asp:ListItem>
                        <asp:ListItem Value="3">Alienware</asp:ListItem>
                        <asp:ListItem Value="4">MSI</asp:ListItem>
                        <asp:ListItem Value="5">Toshiba</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Modelo"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList4" runat="server" Width="118px">
                        <asp:ListItem Value="0">Serie 5000</asp:ListItem>
                        <asp:ListItem Value="1">Serie 7000</asp:ListItem>
                        <asp:ListItem Value="2">Serie 3000</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Tipo"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="121px">
                        <asp:ListItem>Laptop</asp:ListItem>
                        <asp:ListItem>UltraSlim</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Memoria Interna de Video (GB)"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtmem" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Tamaño Pantalla"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPantalla" runat="server"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Sistema Operativo"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="121px">
                        <asp:ListItem>Windows</asp:ListItem>
                        <asp:ListItem>Linux</asp:ListItem>
                        <asp:ListItem>UNIX</asp:ListItem>
                        <asp:ListItem>MAC OS</asp:ListItem>
                        <asp:ListItem>Android</asp:ListItem>
                        <asp:ListItem>IOS</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Procesador"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtprocesador" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="RAM"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtram" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Camara Primaria"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtcamara" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Cantidad de USB"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtusb" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Tamaño Batería (Amperios)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtbateria" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Fecha de Lanzamiento"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    
                </td>
                <td>
                    
                </td>
            </tr>
        </table>
        <br />
        <br />

        <table align="center">
            <tr>
                <td>
                    <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" Style="height: 26px" />
                </td>
                <td>
                    <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                </td>
            </tr>
        </table>
        </div>

    <br />
        <br />
        <asp:GridView ID="gvData" runat="server" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvData_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ButtonType="Button" DeleteText="" InsertText="" NewText="" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
</asp:Content>
