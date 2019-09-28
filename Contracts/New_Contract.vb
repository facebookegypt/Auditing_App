Imports System.Data.OleDb
Public Class New_Contract
    Dim Summary As String = String.Empty
    Dim Proj() As String
    Dim Cntrctr() As String
    Dim Curren() As String
    Dim ProjectID As Long = -1
    Dim ContractorID As Long = -1
    Dim SubCntrID As Long = -1
    Dim CurID As Long = -1
    Dim AllCntrCurr As String = String.Empty

    Private Sub New_Contract_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub
    Private Sub New_Contract_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'Escape Press
        If e.KeyChar = Chr(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub New_Contract_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Populate ListBox with Projects
        ProjLst.DataSource = Nothing
        ProjLst.Items.Clear()
        Dim ProjComboCMD As New OleDbCommand
        'You can change this Sql Statement to be .. SELECT TOP 100 .. for easy testing.
        'Of find a way to populate ComboBox with 29.8k data without waiting.
        Dim SqlStr As String =
            ("SELECT * FROM Projects")
        _ExcuteCMD(SqlStr, ProjComboCMD)
        Dim ProjComboReader As OleDbDataReader = ProjComboCMD.ExecuteReader
        Dim ProjComboItems As New Dictionary(Of String, String)()
        If ProjComboReader.HasRows Then
            ProjLst.BeginUpdate()
            While ProjComboReader.Read
                ProjComboItems.Add(ProjComboReader!ProjID.ToString, ProjComboReader!ProjNm)
            End While
            ProjComboReader.Close()
        Else
            ProjComboItems.Add(0, "No Projects")
        End If
        ProjComboCMD.Dispose()
        With ProjLst
            .DataSource = New BindingSource(ProjComboItems, Nothing)
            .DisplayMember = "Value"
            .ValueMember = "key"
            .Text = String.Empty
            .EndUpdate()
        End With
        '=============================Contractor ListBox
        'Populate ListBox with Projects
        CntrctrLst.DataSource = Nothing
        CntrctrLst.Items.Clear()
        Dim CntrctrLstCMD As New OleDbCommand
        'You can change this Sql Statement to be .. SELECT TOP 100 .. for easy testing.
        'Of find a way to populate ComboBox with 29.8k data without waiting.
        Dim SqlStr1 As String =
            ("SELECT * FROM Contractors")
        _ExcuteCMD(SqlStr1, CntrctrLstCMD)
        Dim CntrctrLstReader As OleDbDataReader = CntrctrLstCMD.ExecuteReader
        Dim CntrctrLstItems As New Dictionary(Of String, String)()
        If CntrctrLstReader.HasRows Then
            CntrctrLst.BeginUpdate()
            While CntrctrLstReader.Read
                CntrctrLstItems.Add(CntrctrLstReader!CntrctrID.ToString, CntrctrLstReader!CntrctrNM)
            End While
            CntrctrLstReader.Close()
        Else
            CntrctrLstItems.Add(0, "No Contractors")
        End If
        CntrctrLstCMD.Dispose()
        With CntrctrLst
            .DataSource = New BindingSource(CntrctrLstItems, Nothing)
            .DisplayMember = "Value"
            .ValueMember = "key"
            .Text = String.Empty
            .EndUpdate()
        End With
    End Sub
    Private Sub LstSubs_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim ID As String() = LstSubs.Text.Split("-")
        SubCntrID = ID(0)
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If IsNothing(CntrctrLst.SelectedValue) Or _
            IsNothing(LstSubs.SelectedValue) Or _
            IsNothing(ProjLst.SelectedValue) Then

        End If
        ContractorID = _
             CLng(DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key())
        ProjectID = _
             CLng(DirectCast(ProjLst.SelectedItem, KeyValuePair(Of String, String)).Key())
        'Key is nothing
        SubCntrID = _
             CLng(DirectCast(LstSubs.SelectedItem, KeyValuePair(Of String, String)).Key())

        If ProjectID = -1 Or _
            SubCntrID = -1 Or _
            ContractorID = -1 Then
            MsgBox("Choose Project first, then choose a Contractor.", , Now.ToShortDateString)
            ProjLst.Select()
            Exit Sub
        End If
        '===========================================================================
        ' Start a local transaction with ReadCommitted isolation level.
        '  Dim SS As OleDbTransaction = CN.BeginTransaction(Data.IsolationLevel.ReadCommitted)
        '-------------------------------------------------------------------------------------
        'Curr(N) edited on 16/Feb/2019 FROM NUMBER OF CURR
        Dim SqlInsert As String = _
            ("INSERT INTO Contracts (Cntrct_Name_Ara,Cntrct_Name_Eng,Cntrct_Dscrp,Cntrct_Start,Cntrct_End,CntrctrID,SubCntrctr_ID,ProjID) " & _
                   "VALUES (@_CnmAr,@_CnmEn,@_Cds,@_Cdstr,@_Cestr,@_CntrID,@_SbcntrID,@_PrID)")
        Dim CMDFill As New OleDbCommand
        _ExcuteCMD(SqlInsert, CMDFill)
        With CMDFill.Parameters
            .AddWithValue("@_CnmAr", CntrctNmAra.Text)
            .AddWithValue("@_CnmEn", CntrctNmEng.Text)
            .AddWithValue("@_Cds", Tsumma.Text)
            .AddWithValue("@_Cdstr", DTP1.Value.ToShortDateString)
            .AddWithValue("@_Cestr", DTP2.Value.ToShortDateString)
            .AddWithValue("@_CntrID", ContractorID)
            .AddWithValue("@_SbcntrID", SubCntrID)
            .AddWithValue("@_PrID", ProjectID)
        End With
        Try
            CMDFill.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error Sql : " & ex.Message)
            Exit Sub
        End Try
        Try
            Trans.Commit()
        Catch ex As Exception
            Trans.Rollback()
            MsgBox("Error Insert : " & ex.Message)
            Exit Sub
        End Try
        CMD.Parameters.Clear()
        CMDFill.Dispose()
        Trans.Dispose()
        MsgBox("Contract added successfully.")  'Sept/2019
        '07/May/2016
    End Sub
    Private Sub CntrctrLst_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles CntrctrLst.SelectedValueChanged
        'Contractor ID
        ContractorID = _
            DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key()
        If ContractorID = -1 Then
            Exit Sub
        End If
        '----------Fill Sub Contractors list-------------
        'Populate ListBox with Projects
        LstSubs.DataSource = Nothing
        LstSubs.Items.Clear()
        Dim LstSubsCMD As New OleDbCommand
        'You can change this Sql Statement to be .. SELECT TOP 100 .. for easy testing.
        'Of find a way to populate ComboBox with 29.8k data without waiting.
        Dim SqlStr As String =
            ("SELECT * FROM SubContractors WHERE CntrctrID=" & ContractorID & ";")
        _ExcuteCMD(SqlStr, LstSubsCMD)
        Dim lstSubReader As OleDbDataReader = LstSubsCMD.ExecuteReader
        Dim LstSubsItems As New Dictionary(Of String, String)()
        If lstSubReader.HasRows Then
            LstSubs.BeginUpdate()
            While lstSubReader.Read
                LstSubsItems.Add(lstSubReader!SubCntrctr_ID.ToString, lstSubReader!SubCntrctr_Co_Name)
            End While
            lstSubReader.Close()
        Else
            LstSubsItems.Add(0, "No SubContractors")
        End If
        LstSubsCMD.Dispose()
        If LstSubsItems.Count = 0 Then Exit Sub
        With LstSubs
            .DataSource = New BindingSource(LstSubsItems, Nothing)
            .DisplayMember = "Value"
            .ValueMember = "key"
            .Text = String.Empty
            .EndUpdate()
        End With
    End Sub
    Private Sub ProjLst_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ProjLst.SelectedValueChanged
        ProjectID = _
             DirectCast(ProjLst.SelectedItem, KeyValuePair(Of String, String)).Key()
    End Sub
    Private Sub CntrctrLst_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CntrctrLst.SelectedIndexChanged
        ContractorID = _
             DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key()
    End Sub
End Class