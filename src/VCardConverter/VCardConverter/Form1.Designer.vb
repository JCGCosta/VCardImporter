<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvExibirXlsx = New System.Windows.Forms.DataGridView()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvExibirXlsx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.Location = New System.Drawing.Point(12, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(126, 23)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "ImportarArquivoXls"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 42)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgvExibirXlsx
        '
        Me.dgvExibirXlsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExibirXlsx.Location = New System.Drawing.Point(12, 89)
        Me.dgvExibirXlsx.Name = "dgvExibirXlsx"
        Me.dgvExibirXlsx.Size = New System.Drawing.Size(384, 186)
        Me.dgvExibirXlsx.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(258, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(138, 23)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "ExportarArquivoCsv"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(6, 16)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Feito por Julio Cesar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 306)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dgvExibirXlsx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImport)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar VCards"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvExibirXlsx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImport As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvExibirXlsx As DataGridView
    Friend WithEvents btnExport As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label1 As Label
End Class
