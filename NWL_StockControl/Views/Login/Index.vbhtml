@ModelType NWL_StockControl.TMstMUser

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Using (Html.BeginForm("LoginCheck", "Login"))
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
    <h4>ไก่</h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        @Html.LabelFor(Function(model) model.XVUsrCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.XVUsrCode, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.XVUsrCode, "", New With {.class = "text-danger"})
        </div>
    </div>

    @*<div class="form-group">
            @Html.LabelFor(Function(model) model.XVUsrName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.XVUsrName, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.XVUsrName, "", New With { .class = "text-danger" })
            </div>
        </div>*@

    <div class="form-group">
        @Html.LabelFor(Function(model) model.XVUsrPwd, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.XVUsrPwd, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.XVUsrPwd, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Login" class="btn btn-default" />
        </div>
    </div>
</div>
    End Using


        <div>
            @Html.ActionLink("Back to List", "Index")
        </div>
    </body>
    </html>
