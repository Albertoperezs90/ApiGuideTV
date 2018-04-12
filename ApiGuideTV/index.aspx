<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ApiGuideTV.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Import Google Icon Font-->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <!--Import materialize.css-->
    <link type="text/css" rel="stylesheet" href="Resources/css/materialize.min.css" media="screen,projection" />

    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!--JavaScript at end of body for optimized loading-->
    <script type="text/javascript" src="Resources/js/materialize.min.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Table ID="myTable" runat="server" CssClass="striped">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>
                        <asp:Label runat="server">Method</asp:Label>
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        <asp:Label runat="server">Description</asp:Label>
                    </asp:TableHeaderCell>
                    <asp:TableHeaderCell>
                        <asp:Label runat="server">Path</asp:Label>
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server">GET</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label runat="server">Get all programs/movies/series starting now</asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label runat="server"><a href="now.aspx">/now</a></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
