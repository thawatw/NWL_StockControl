@ModelType IEnumerable(Of NWL_StockControl.TMnyMUserMenuWithMenuName)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">
@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/jqueryval")
<style>
    body, html {
        height: 100vh;
        background-repeat: no-repeat;
        background-image: linear-gradient(rgb(255, 130, 71), rgb(146, 64, 26));
        max-height: 100vh;
    }

</style>
<body>

    <div class="px-5">
        <div class="py-5">
            <div class="card " >
                <div class="card-header" style="background-color: rgb(71, 171, 255)">
                  <h1 class="text-center text-white">เมนู</h1>
                </div>
                <div Class="card-body overflow-auto" style="height: 79vh; max-height: 79vh; ">
                        <div class="row hidden-md-up">
                            @For Each item In Model
                                If item.XBUmnIsRead Then
                                    @*@<p>
                                <input type="button" value="@item.XVMnuName" id="@item.XVMnuCode" />
                            </p>*@
                                    @<div Class="col-md-3 col-sm-12 py-2" >
                                        <div Class="card">
                                            <div Class="card-body">
                                                <h3 Class="card-title m-2 text-center">@item.XVMnuCode :@item.XVMnuName</h3>
                                            </div>
                                        </div>
                                    </div>
                                End If
                            Next
                        </div>
                 
                </div>
            </div>
        </div>
    </div>
</body>
</html>
