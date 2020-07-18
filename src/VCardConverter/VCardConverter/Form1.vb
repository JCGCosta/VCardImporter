Imports System.IO
Imports System.Data

Public Class Form1

    Dim strFileName As String = ""

    Private Function AccessDatabaseEngineInstalled() As Boolean

        Dim FileName1 As String 'Location Prior to Windows 7
        Dim FileName2 As String 'Location for Windows 7 (Not sure if this file location is for the 64bit version of Windows 7 only)

        FileName1 = "C:\Program Files\Common Files\microsoft shared\OFFICE12\ACECORE.DLL"
        FileName2 = "C:\Program Files (x86)\Common Files\microsoft shared\OFFICE12\ACECORE.DLL"

        If File.Exists(FileName1) Or File.Exists(FileName2) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If AccessDatabaseEngineInstalled() = True Then
            lblInfo.Text = "Programa Pronto para ser utilizado."
            btnExport.Enabled = True
            btnImport.Enabled = True
        Else
            lblInfo.Text = "Por Favor instale o conector Ole.Db."
        End If

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        lblInfo.Text = "Importando Arquivo."

        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Abra um arquivo Xls"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Excel Files(.xls)|*.xls"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        Else
            lblInfo.Text = "Programa Pronto para ser utilizado."
        End If

        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = strFileName
            Dim numLinhasdgv As Integer


            If strFileName <> "" Then

                MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
                MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [VCardSheet$]", MyConnection)

                dataSet = New System.Data.DataSet
                MyCommand.Fill(dataSet)
                dgvExibirXlsx.DataSource = dataSet.Tables(0)
                numLinhasdgv = dgvExibirXlsx.Rows.Count - 1

                MyConnection.Close()
                lblInfo.Text = "Arquivo Importado, quantidade de linhas encontradas: " + numLinhasdgv.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Feche o programa Excel para continuar.", "Feche o excel.")
        End Try


    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        lblInfo.Text = "Exportanto Arquivo csv."

        'create empty string
        Dim thecsvfile As String = String.Empty
        'get the column headers
        For Each column As DataGridViewColumn In dgvExibirXlsx.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next
        'trim the last comma
        thecsvfile = thecsvfile.TrimEnd(",")
        'Add the line to the output
        thecsvfile = thecsvfile & vbCr & vbLf
        'get the rows
        For Each row As DataGridViewRow In dgvExibirXlsx.Rows
            'get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'write the file
        My.Computer.FileSystem.WriteAllText(strFileName.Replace("Importação.xls", "ImportaçãoGmail.csv"), thecsvfile, False)
        MessageBox.Show("Arquivo csv pronto para ser utilizado." + vbCrLf + "Diretório: " + vbCrLf + strFileName.Replace("Importação.xls", "ImportaçãoGmail.csv"), "Arquivo Exportado!")
    End Sub

End Class
