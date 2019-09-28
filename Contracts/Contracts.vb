Imports System.Globalization

Public Class Contracts
    Private Sub Contracts_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub
    Private Sub Contracts_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then Close()
    End Sub
    Private Sub Contracts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '-----Contracts------------------------------------------------------------------------------------------------------------
        Dim SqlStr As String = _
            "SELECT Projects.ProjID, Projects.ProjNm, Contracts.Contract_ID, Contracts.Cntrct_Name_Ara, " & _
             "Contracts.Cntrct_Name_Eng, SubContractors.SubCntrctr_Co_Name, Contractors.CntrctrNM, Contractors.CntrctrID " & _
             "FROM SubContractors INNER JOIN (Contractors INNER JOIN (Projects INNER JOIN Contracts " & _
             "ON Projects.ProjID = Contracts.ProjID) ON Contractors.CntrctrID = Contracts.CntrctrID) " & _
             "ON (Contractors.CntrctrID = SubContractors.CntrctrID) AND (SubContractors.SubCntrctr_ID = Contracts.SubCntrctr_ID);"
        '=====End Contracts========================================================================================================

        '------- Currencies---------------------------------------
        TreeViewContracts(ProjTRV, SqlStr)
        UpdateTreeView(CurrTreeView, "SELECT * FROM Currencies;")
        '=======End Currencies====================================
        Dim SqlStr1 As String = _
            ("")
    End Sub
    Private Sub CurrTreeView_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles CurrTreeView.AfterSelect
        If e.Node.Index = -1 Then
            CntrctValueTextBox.ReadOnly = True
            MsgBox("Choose Currency")
            Exit Sub
        End If
        CntrctValueTextBox.ReadOnly = False
        Dim SqlStr As String = _
            ("SELECT CurrSymbol FROM Currencies WHERE Currencies.CurrID=" & CLng(e.Node.Name))
        Dim CmdCurr As New Data.OleDb.OleDbCommand
        _ExcuteCMD(SqlStr, CmdCurr)
        Dim CurrReader = CmdCurr.ExecuteReader
        If CurrReader.HasRows Then
            While CurrReader.Read
                lblCurr.Text = CurrReader!CurrSymbol
            End While
            CurrReader.Close()
        Else
            lblCurr.Text = String.Empty
        End If
    End Sub

    Private Sub CntrctValueTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CntrctValueTextBox.TextChanged
        If Not IsNumeric(CntrctValueTextBox.Text) Then
            SendKeys.Send("{BackSpace}")
            Exit Sub
        End If
    End Sub

    Private Sub ProjTRV_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles ProjTRV.AfterSelect

    End Sub

    Private Sub ProjTRV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ProjTRV.KeyDown
        If e.KeyValue = (Keys.Add) Then
            If _
                ProjTRV.SelectedNode.IsExpanded Then
                ProjTRV.SelectedNode.Collapse(True)
            Else
                ProjTRV.SelectedNode.Expand()
            End If
        End If
    End Sub

    Private Sub ProjTRV_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ProjTRV.KeyPress

    End Sub
End Class