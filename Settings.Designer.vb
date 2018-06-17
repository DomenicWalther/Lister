<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbSearchList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(37, 525)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(310, 20)
        Me.txtKey.TabIndex = 0
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(389, 525)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(310, 20)
        Me.txtLink.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Link"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(37, 571)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Entry"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lbSearchList
        '
        Me.lbSearchList.ColumnWidth = 20
        Me.lbSearchList.FormattingEnabled = True
        Me.lbSearchList.Location = New System.Drawing.Point(37, 22)
        Me.lbSearchList.MultiColumn = True
        Me.lbSearchList.Name = "lbSearchList"
        Me.lbSearchList.Size = New System.Drawing.Size(662, 459)
        Me.lbSearchList.TabIndex = 5
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 622)
        Me.Controls.Add(Me.lbSearchList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.txtKey)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKey As TextBox
    Friend WithEvents txtLink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lbSearchList As ListBox
End Class
