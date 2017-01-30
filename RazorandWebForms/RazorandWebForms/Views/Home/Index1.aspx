<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index1.aspx.cs" Inherits="RazorandWebForms.Views.Home.Index1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <%
         int a = 100;
         int b = 200;
      %>
        <h2> Sum <%= a+ b %></h2>

        <%
            for (byte i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                { %>
                    <h3 style="color:blue"> Even : <%= i %></h3>
                <%}
    else
    { %>
                   <h3 style="color:brown"> Odd : <%= i %></h3>
                <% }
       }%>
    </div>
    </form>
</body>
</html>
