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
<body>

    @For Each item In Model
        If item.XBUmnIsRead Then
            @<p>
                <input type="button" value="@item.XVMnuName" id="@item.XVMnuCode" />
            </p>
        End If
    Next


</body>
</html>
