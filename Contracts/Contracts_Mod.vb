Module Contracts_Mod
    Public Sub TreeViewContracts(TV As TreeView, SqlStr As String)
        SqlStr = _
            ("SELECT Projects.ProjID, Projects.ProjNm, Contracts.Contract_ID, Contracts.Cntrct_Name_Ara, " & _
             "Contracts.Cntrct_Name_Eng, SubContractors.SubCntrctr_Co_Name, Contractors.CntrctrNM, Contractors.CntrctrID " & _
             "FROM SubContractors INNER JOIN (Contractors INNER JOIN (Projects INNER JOIN Contracts " & _
             "ON Projects.ProjID = Contracts.ProjID) ON Contractors.CntrctrID = Contracts.CntrctrID) " & _
             "ON (Contractors.CntrctrID = SubContractors.CntrctrID) AND (SubContractors.SubCntrctr_ID = Contracts.SubCntrctr_ID);")
        TV.Nodes.Clear()
        Dim TRN, TRN1, TRN2, TRN3 As TreeNode
        TV.BeginUpdate()
        Dim SelectCMD As New Data.OleDb.OleDbCommand
        _ExcuteCMD(SqlStr, SelectCMD)
        Dim SelectReader As Data.OleDb.OleDbDataReader = SelectCMD.ExecuteReader
        If SelectReader.HasRows Then
            While SelectReader.Read
                'TRN : Full Name
                TRN = New TreeNode(SelectReader!Contract_ID.ToString)
                With TRN
                    .Name = SelectReader!ProjID
                    .Text = SelectReader!Cntrct_Name_Ara
                End With
                TV.Nodes.Add(TRN)
                '''''''''''''''''
                TRN1 = New TreeNode(SelectReader!Contract_ID.ToString)
                With TRN1
                    .Name = SelectReader!Contract_ID
                    .Text = SelectReader!ProjNm
                End With
                TRN.Nodes.Add(TRN1)
                TRN2 = New TreeNode(SelectReader!Contract_ID.ToString)
                With TRN2
                    .Name = SelectReader!Contract_ID
                    .Text = SelectReader!Cntrct_Name_Eng
                End With
                TRN.Nodes.Add(TRN2)
                TRN3 = New TreeNode(SelectReader!Contract_ID.ToString)
                With TRN3
                    .Name = SelectReader!CntrctrID
                    .Text = SelectReader!CntrctrNM
                End With
                TRN.Nodes.Add(TRN3)
            End While
            SelectReader.Close()
        End If
        TV.EndUpdate()
    End Sub
End Module
