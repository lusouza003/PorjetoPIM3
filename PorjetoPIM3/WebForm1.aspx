<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PorjetoPIM3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!DOCTYPE html>
        <html lang="en" dir="ltr">
        <head>
            <meta charset="utf-8">
            <title>Tela de Login Pim</title>
            <link rel="stylesheet" href="style.css">
        </head>
        <body>
            <div class="center">
                <h1>Login</h1>
                <form method="post">
                    <div class="txt_field">
                        <input type="text" id="txtUsuario" name="txtUsuario" runat="server" required>
                        <span></span>
                        <label>Usuário</label>
                    </div>
                    <div class="txt_field">
                        <input type="password" id="txtSenha" name="txtSenha" runat="server" required>
                        <span></span>
                        <label>Senha</label>
                    </div>
                    <div class="pass">Esqueceu a Senha?</div>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /> <!-- Botão de login com evento de servidor -->
                    <asp:Label ID="lblMensagem" runat="server" Visible="false" ForeColor="Red"></asp:Label>

                    <div class="signup_link">
                        Não é um Membro? <a href="#">Inscreva-se</a>
                    </div>
                </form>
            </div>
        </body>
        </html>
        <div>
        </div>
    </form>
</body>
</html>
