Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Module Database
   Public CN As New OleDbConnection
   Public CMD As New OleDbCommand
    Public ConnStr As String
    Public Trans As OleDbTransaction
   Public Function CheckDB(DBPath As String) As Boolean
      If CN.State = 1 Then CN.Close()
      If System.IO.File.Exists(DBPath) Then
            CN.ConnectionString = ("Provider=Microsoft.Jet.OleDB.4.0 ; Data Source = " & DBPath)
            Try
                CN.Open()
            Catch ex As Exception
                MsgBox("Error Database : " & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                Return False
                Exit Function
            End Try
         ConnStr = CN.ConnectionString
         Return True
      Else
            ConnStr = String.Empty
            MsgBox("Database doesn't exist", MsgBoxStyle.Critical)
         Return False
      End If
   End Function
   Public Function GetConStr()
      Dim StreamRdr As StreamReader = New StreamReader("..\..\Ini\ConStr.txt")
      Dim ConStr As String = ("Provider=Microsoft.Jet.OleDB.4.0 ; Data Source = " & StreamRdr.ReadLine)
      Return ConStr
      StreamRdr.Close()
      StreamRdr.Dispose()
   End Function
   Public Sub GetAllTables(CONN As OleDbConnection, TRV As TreeView)
      CONN = CN
      If CONN.State = 1 Then CONN.Close()
      CONN.Open()
      TRV.Nodes.Clear()
      Dim tablename As DataTable = CONN.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, _
                                                            New Object() {Nothing, Nothing, Nothing, "TABLE"})
      Dim ViewName As DataTable = CONN.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, _
                                                   New Object() {Nothing, Nothing, Nothing, "VIEW"})
      For Each row As DataRow In tablename.Rows
         Dim TblRoot As TreeNode = TRV.Nodes.Add(key:="Tables", imageIndex:=0, text:=row("TABLE_NAME"))
         TblRoot.ToolTipText = ("TABLE")
         DisplayColTypeName(CONN, TblRoot)
         'GetPrimaryKey(CONN, TblRoot)
      Next

      For Each row As DataRow In ViewName.Rows
         Dim TblRoot1 As TreeNode = TRV.Nodes.Add(key:="VIEWS", imageIndex:=4, text:=row("TABLE_NAME"))
         DisplayColTypeName(CONN, TblRoot1)
         'GetPrimaryKey(CONN, TblRoot)
         TblRoot1.ToolTipText = ("VIEW")
      Next
   End Sub
    Sub DisplayColTypeName(Cn As OleDb.OleDbConnection, Root As TreeNode)
        'Used in GetAllTables function to return ColumnName Type(Length,Decimal)

        'Complete the TreeView [Table(1,2,3), Columns(1,2,3), DataType]
        'Table1(Column1,Type1)
        'Table1(Column2,Type1)
        Dim tablename As DataTable = Cn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, _
                        New Object() {Nothing, Nothing, Root.Text, Nothing})
        Dim ThisColName As String
        For Each row As DataRow In tablename.Rows
            'Get Column Names
            ThisColName = row("COLUMN_NAME").ToString.Trim
            Dim schemaTable As DataTable = Cn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, _
                    New Object() {Nothing, Nothing, Root.Text})
            Dim ThisColType As Integer = row("DATA_TYPE").ToString.Trim
            Dim ColRoot As TreeNode = Root.Nodes.Add(key:="Columns", imageIndex:=2, text:=ThisColName)
            'Get DataType
            Dim IsPrim As String = GetPrimaryKey(Cn, Root)
            If IsPrim = ThisColName Then
                ColRoot.ForeColor = Color.Red
                ColRoot.ToolTipText = ("Primary Key")
            End If
            Dim TypeRoot As TreeNode = ColRoot.Nodes.Add(key:="DataType", text:=GetName1Type(ThisColType))
        Next
    End Sub
   Public Function GetPrimaryKey(Cn As OleDb.OleDbConnection, Root As TreeNode) As String
      Dim schemaTable As DataTable = Cn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, _
                 New Object() {Nothing, Nothing, Root.Text})
      Dim ThisColType As String = String.Empty 
      For Each row As DataRow In schemaTable.Rows
         ThisColType = (row(3)).ToString
        Next
        Return ThisColType
   End Function
   Private Function GetName1Type(ThisType As Integer) As String
      'Used in DisplayColTypeName to convert the Integer Type to String Type name
      Dim TheName As String = ""
      Select Case ThisType
         Case Is = 11
            TheName = "YesNo"
         Case Is = 6
            TheName = "Currency"
         Case Is = 7
            TheName = "Date"
         Case Is = 5
            TheName = "Double"
         Case Is = 3
            TheName = "AutoNumber"
         Case Is = 205
            TheName = "OLEObject"
         Case Is = 203
            TheName = "Memo"
         Case Is = 131
            TheName = "Decimal"
         Case Is = 4
            TheName = "Single"
         Case Is = 2
            TheName = "Integer"
         Case Is = 17
            TheName = "Byte"
         Case Is = 130
            TheName = "Text"
      End Select
      Return TheName
   End Function
   Public Sub LoadDataFromTblsIntoCntr(Tbl As String, Fld As String, _
                                       Cntrl As ListBox, _
                                       SQLstr2 As String, _
                                       Msg1 As String)
      'Load Data into control, using SELECT *
      Dim SqlStr1 As String = ""
      Try
            DBConnected()
            SqlStr1 = ("SELECT * FROM " & Tbl & " WHERE " & Fld & " " & SQLstr2 & ";")
            With CMD
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = SqlStr1
            End With
            Dim DataRdr As OleDbDataReader = CMD.ExecuteReader
            If TypeOf Cntrl Is ListBox Then
                Cntrl.Items.Clear()
                DataRdr.Read()
                Do While DataRdr.Read = True
                    Cntrl.Items.Add(DataRdr!FLD)
                Loop
            End If
            DataRdr.Close()
        Catch ex As Exception
            Msg1 = ("Error :" & ex.Message)
        End Try
    End Sub
    Public Sub DataGrid_Work(MySql1 As String, DG As DataGridView)
        Dim MyCmd1 As New OleDbCommand
        Dim MyTable1 As New DataTable
        Dim DataR1 As OleDbDataReader
        DBConnected()
        Try
            With MyCmd1
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = MySql1
            End With
            DataR1 = MyCmd1.ExecuteReader
            Dim I As Integer
            For I = 0 To MyTable1.Rows.Count - 1
                DataR1.Read()
            Next
            MyTable1.Load(DataR1)
            DG.DataSource = MyTable1

            Dim L As Integer = DG.Columns.Count
            With DG
                For I = 0 To L - 1
                    DG.Columns(I).Width = DG.Width / L
                Next
            End With
            DataR1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub _ExcuteCMD(SqlStmnt As String, CMD As OleDbCommand)
        If DBConnected() Then
            Trans = CN.BeginTransaction(IsolationLevel.ReadCommitted)
            With CMD
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = SqlStmnt
                .Transaction = Trans
            End With
        End If
    End Sub
End Module
